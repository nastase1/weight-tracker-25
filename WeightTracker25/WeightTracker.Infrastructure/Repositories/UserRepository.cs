using Microsoft.EntityFrameworkCore;
using WeightTracker.Domain.Entities;
using WeightTracker.Domain.IRepositories;
using WeightTracker.Infrastructure.Context;

namespace WeightTracker.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WeightTrackerDbContext _context;

        public UserRepository(WeightTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<Users?> GetByIdAsync(Guid userId)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.UserId == userId && u.DeletedAt == null);
        }

        public async Task<Users?> GetByEmailAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email && u.DeletedAt == null);
        }

        public async Task<Users?> GetByUsernameAsync(string username)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.DeletedAt == null);
        }

        public async Task<IEnumerable<Users>> GetAllAsync()
        {
            return await _context.Users
                .Where(u => u.DeletedAt == null).Where(u => u.IsAdmin == false)
                .ToListAsync();
        }

        public async Task<Users> AddAsync(Users user)
        {
            user.UserId = Guid.NewGuid();
            user.CreatedAt = DateTime.UtcNow;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Users> UpdateAsync(Users user)
        {
            user.UpdatedAt = DateTime.UtcNow;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteAsync(Guid userId)
        {
            var user = await GetByIdAsync(userId);
            if (user == null) return false;

            user.DeletedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid userId)
        {
            return await _context.Users
                .AnyAsync(u => u.UserId == userId && u.DeletedAt == null);
        }
    }
}