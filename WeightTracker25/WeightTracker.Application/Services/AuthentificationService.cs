using WeightTracker.Application.IServices;
using WeightTracker.Shared.DTOs.Responses.User;
using WeightTracker.Domain.IRepositories;
using WeightTracker.Shared.DTOs.Requests.User;
using WeightTracker.Domain;
using WeightTracker.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WeightTracker.Application.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        private readonly IPasswordResetTokenRepository _passwordResetTokenRepository;

        public AuthentificationService(IUserRepository userRepository, IConfiguration configuration, IEmailService emailService, IPasswordResetTokenRepository passwordResetTokenRepository)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _emailService = emailService;
            _passwordResetTokenRepository = passwordResetTokenRepository;
        }

        public async Task<UserRegisterResponseDTO> RegisterUserAsync(UserRegisterRequestDTO request)
        {
            var userByEmail = await _userRepository.GetByEmailIncludingInactiveAsync(request.Email);
            if (userByEmail != null)
            {
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = "A user with this email already exists."
                };
            }

            var userByUsername = await _userRepository.GetByUsernameIncludingInactiveAsync(request.Username);
            if (userByUsername != null)
            {
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = "A user with this username already exists."
                };
            }

            var newUser = new Users
            {
                UserId = Guid.NewGuid(),
                IsAdmin = false,
                Username = request.Username,
                Email = request.Email,
                PasswordHash = HashPassword(request.Password),
                LoginProvider = null, // Regular email/password registration
                ExternalUserId = null,
                CreatedAt = DateTime.UtcNow
            };

            await _userRepository.AddAsync(newUser);
            try
            {
                await _emailService.SendWelcomeEmailAsync(newUser.Email, newUser.Username);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send welcome email: {ex.Message}");
            }
            return new UserRegisterResponseDTO
            {
                Success = true,
                Message = "User registered successfully."
            };
        }

        public async Task<UserLoginResponseDTO> LoginUserAsync(UserLoginRequestDTO request)
        {
            var user = await _userRepository.GetByEmailIncludingInactiveAsync(request.Email);
            if (user == null)
            {
                return new UserLoginResponseDTO
                {
                    Success = false,
                    Token = null,
                    Message = "Invalid username or password."
                };
            }

            if (!VerifyPassword(request.Password, user.PasswordHash))
            {
                return new UserLoginResponseDTO
                {
                    Success = false,
                    Token = null,
                    Message = "Invalid username or password."
                };
            }

            if(user.DeletedAt != null)
            {
                return new UserLoginResponseDTO
                {
                    Success = false,
                    Token = null,
                    Message = "This account has been deactivated."
                };
            }

            var token = GenerateJwtToken(user, request.RememberMe);

            return new UserLoginResponseDTO
            {
                Success = true,
                Token = token,
                Message = "Login successful."
            };
        }

        private string GenerateJwtToken(Users user, bool rememberMe)
        {
            var jwtKey = _configuration["Jwt:Key"] ?? throw new InvalidOperationException("JWT Key is not configured.");
            var jwtIssuer = _configuration["Jwt:Issuer"] ?? throw new InvalidOperationException("JWT Issuer is not configured.");
            var jwtAudience = _configuration["Jwt:Audience"] ?? throw new InvalidOperationException("JWT Audience is not configured.");

            var expiryTime = rememberMe
                ? DateTime.UtcNow.AddDays(30)
                : DateTime.UtcNow.AddHours(24);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserId.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: jwtIssuer,
                audience: jwtAudience,
                claims: claims,
                expires: expiryTime,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }

        public async Task<ForgotPasswordResponseDTO> ForgotPasswordAsync(ForgotPasswordRequestDTO request)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email);
            if (user == null)
            {
                return new ForgotPasswordResponseDTO
                {
                    Success = true,
                    Message = "If the email exists, a reset code has been sent."
                };
            }

            var random = new Random();
            var resetCode = random.Next(100000, 999999).ToString();

            var resetToken = new PasswordResetToken
            {
                TokenId = Guid.NewGuid(),
                UserId = user.UserId,
                ResetCode = resetCode,
                ExpiryDate = DateTime.UtcNow.AddMinutes(15),
                IsUsed = false,
                CreatedAt = DateTime.UtcNow
            };

            await _passwordResetTokenRepository.AddAsync(resetToken);

            try
            {
                await _emailService.SendPasswordResetCodeAsync(user.Email, user.Username, resetCode);
            }
            catch (Exception)
            {
                return new ForgotPasswordResponseDTO
                {
                    Success = false,
                    Message = "Failed to send reset code email. Please try again."
                };
            }

            return new ForgotPasswordResponseDTO
            {
                Success = true,
                Message = "If the email exists, a reset code has been sent."
            };
        }

        public async Task<ResetPasswordResponseDTO> ResetPasswordAsync(ResetPasswordRequestDTO request)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email);
            if (user == null)
            {
                return new ResetPasswordResponseDTO
                {
                    Success = false,
                    Message = "Invalid email or reset code."
                };
            }

            var resetToken = await _passwordResetTokenRepository.GetValidTokenAsync(user.UserId, request.ResetCode);

            if (resetToken == null)
            {
                return new ResetPasswordResponseDTO
                {
                    Success = false,
                    Message = "Invalid or expired reset code."
                };
            }

            user.PasswordHash = HashPassword(request.NewPassword);
            user.UpdatedAt = DateTime.UtcNow;
            await _userRepository.UpdateAsync(user);

            resetToken.IsUsed = true;
            await _passwordResetTokenRepository.UpdateAsync(resetToken);

            return new ResetPasswordResponseDTO
            {
                Success = true,
                Message = "Password reset successfully. You can now login with your new password."
            };
        }
    }
}