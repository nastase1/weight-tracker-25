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

        public AuthentificationService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task<UserRegisterResponseDTO> RegisterUserAsync(UserRegisterRequestDTO request)
        {
            // Check if email already exists
            var userByEmail = await _userRepository.GetByEmailAsync(request.Email);
            if (userByEmail != null)
            {
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = "A user with this email already exists."
                };
            }

            // Check if username already exists
            var userByUsername = await _userRepository.GetByUsernameAsync(request.Username);
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
                Username = request.Username,
                Email = request.Email,
                PasswordHash = HashPassword(request.Password),
                CreatedAt = DateTime.UtcNow
            };

            await _userRepository.AddAsync(newUser);
            return new UserRegisterResponseDTO
            {
                Success = true,
                Message = "User registered successfully."
            };
        }

        public async Task<UserLoginResponseDTO> LoginUserAsync(UserLoginRequestDTO request)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email);
            
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
            
            // If Remember Me is checked, token expires in 30 days, otherwise 24 hours
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
    }
} 