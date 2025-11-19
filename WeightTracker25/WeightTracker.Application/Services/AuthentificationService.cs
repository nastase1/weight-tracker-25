using WeightTracker.Application.IServices;
using WeightTracker.Shared.DTOs.Responses.User;
using WeightTracker.Domain.IRepositories;
using WeightTracker.Shared.DTOs.Requests.User;
using WeightTracker.Domain;
using WeightTracker.Domain.Entities;

namespace WeightTracker.Application.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IUserRepository _userRepository;

        public AuthentificationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserRegisterResponseDTO> RegisterUserAsync(UserRegisterRequestDTO request)
        {
            var userExists = await _userRepository.GetByEmailAsync(request.Username);
            if (userExists != null)
            {
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = "User already exists."
                };
            }
            var newUser = new Users
            {
                UserId = Guid.NewGuid(),
                Username = request.Username,
                Email = request.Email,
                PasswordHash = HashPassword(request.Password)
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
            return await Task.FromResult(new UserLoginResponseDTO
            {
                Success = false,
                Token = null,
                Message = "Login functionality not implemented."
            });
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