using WeightTracker.Domain.Entities;

namespace WeightTracker.Application.IServices
{
    public interface IAdminService
    {
        Task<IEnumerable<Users>> GetAllUsersAsync();
        Task<Users?> GetUserByIdAsync(Guid userId);
    }
}