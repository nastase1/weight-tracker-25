using WeightTracker.Application.IServices;
using WeightTracker.Domain.IRepositories;
using WeigtTracker.Domain.Entities;

namespace WeightTracker.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Users?> GetByIdAsync(int userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        public async Task<Users?> GetByEmailAsync(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task<Users?> GetByUsernameAsync(string username)
        {
            return await _userRepository.GetByUsernameAsync(username);
        }

        public async Task<Users> AddAsync(Users user)
        {
            return await _userRepository.AddAsync(user);
        }

        public async Task<Users> UpdateAsync(Users user)
        {
            return await _userRepository.UpdateAsync(user);
        }

        public async Task<bool> DeleteAsync(int userId)
        {
            return await _userRepository.DeleteAsync(userId);
        }

        public async Task<IEnumerable<Users>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<bool> ExistsAsync(int userId)
        {
            return await _userRepository.ExistsAsync(userId);
        }
    }
}