using WeightTracker.Shared.DTOs.Responses.User;
using WeightTracker.Shared.DTOs.Requests.User;

namespace WeightTracker.Application.IServices
{
    public interface IAuthenticationService
    {
        Task<UserRegisterResponseDTO> RegisterUserAsync(UserRegisterRequestDTO request);
        Task<UserLoginResponseDTO> LoginUserAsync(UserLoginRequestDTO request);
        string HashPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
    }
}