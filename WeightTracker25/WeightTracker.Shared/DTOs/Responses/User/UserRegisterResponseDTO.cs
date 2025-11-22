using WeightTracker.Domain.Entities;

namespace WeightTracker.Shared.DTOs.Responses.User
{
    public class UserRegisterResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string ? Token { get; set; }
        public Users? User { get; set; }
    }
}