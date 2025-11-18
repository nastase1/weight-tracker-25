using WeigtTracker.Domain.Entities;

namespace WeightTracker.Application.IServices
{
    public interface IUserService
    {
        public Task<Users?> GetByIdAsync(int userId);
        public Task<Users?> GetByEmailAsync(string email);
        public Task<Users?> GetByUsernameAsync(string username);
        public Task<Users> AddAsync(Users user);
        public Task<Users> UpdateAsync(Users user);
        public Task<bool> DeleteAsync(int userId);
        public Task<IEnumerable<Users>> GetAllAsync();
        public Task<bool> ExistsAsync(int userId);
    }
}