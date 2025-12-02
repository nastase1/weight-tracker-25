using WeightTracker.Domain.Entities;

namespace WeightTracker.Domain.IRepositories
{
    public interface IUserRepository
    {
        Task<Users?> GetByIdAsync(Guid userId);
        Task<Users?> GetByEmailAsync(string email);
        Task<Users?> GetByEmailIncludingInactiveAsync(string email);
        Task<Users?> GetByUsernameAsync(string username);
        Task<Users?> GetByUsernameIncludingInactiveAsync(string username);
        Task<IEnumerable<Users>> GetAllAsync();
        Task<IEnumerable<Users>> GetAllUsersIncludingInactiveAsync();
        Task<Users> AddAsync(Users user);
        Task<Users> UpdateAsync(Users user);
        Task<bool> DeleteAsync(Guid userId);
        Task<bool> PermanentDeleteAsync(Guid userId);
        Task<bool> ExistsAsync(Guid userId);
    }
}