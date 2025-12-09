using WeightTracker.Shared.DTOs.Responses.User;
using WeightTracker.Shared.DTOs.Requests.User;
using WeightTracker.Domain.Entities;

namespace WeightTracker.Application.IServices
{
    public interface IAuthentificationService
    {
        Task<UserRegisterResponseDTO> RegisterUserAsync(UserRegisterRequestDTO request);
        Task<UserLoginResponseDTO> LoginUserAsync(UserLoginRequestDTO request);
        Task<ForgotPasswordResponseDTO> ForgotPasswordAsync(ForgotPasswordRequestDTO request);
        Task<ResetPasswordResponseDTO> ResetPasswordAsync(ResetPasswordRequestDTO request);
        Task<UserLoginResponseDTO> AuthenticateWithGoogleAsync(string email, string? name, string? googleId);
        string HashPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
    }
}