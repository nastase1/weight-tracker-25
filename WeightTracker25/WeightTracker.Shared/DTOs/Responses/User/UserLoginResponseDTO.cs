namespace WeightTracker.Shared.DTOs.Responses.User
{
    public class UserLoginResponseDTO
    {
        public bool Success { get; set; }
        public string? Token { get; set; }
        public string? Message { get; set; }
    }
}