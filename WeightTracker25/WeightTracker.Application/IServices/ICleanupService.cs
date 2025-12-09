namespace WeightTracker.Application.IServices
{
    public interface ICleanupService
    {
        Task CleanupExpiredUsersAsync();
    }
}