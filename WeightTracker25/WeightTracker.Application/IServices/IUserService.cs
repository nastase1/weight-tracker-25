using WeightTracker.Domain.Entities;

namespace WeightTracker.Application.IServices
{
    public interface IUserService
    {
        public Task<Users?> GetByIdAsync(Guid userId);
        public Task<Users?> GetByEmailAsync(string email);
        public Task<Users?> GetByUsernameAsync(string username);
        public Task<Users> AddAsync(Users user);
        public Task<Users> UpdateAsync(Users user);
        public Task<bool> DeleteAsync(Guid userId);
        public Task<IEnumerable<Users>> GetAllAsync();
        public Task<IEnumerable<Users>> GetAllUsersIncludingInactiveAsync();
        public Task<bool> ExistsAsync(Guid userId);
    }
}