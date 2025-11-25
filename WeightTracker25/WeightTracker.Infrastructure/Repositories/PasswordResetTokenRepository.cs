using Microsoft.EntityFrameworkCore;
using WeightTracker.Domain.Entities;
using WeightTracker.Domain.IRepositories;
using WeightTracker.Infrastructure.Context;

namespace WeightTracker.Infrastructure.Repositories
{
    public class PasswordResetTokenRepository : IPasswordResetTokenRepository
    {
        private readonly WeightTrackerDbContext _context;

        public PasswordResetTokenRepository(WeightTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<PasswordResetToken?> GetValidTokenAsync(Guid userId, string resetCode)
        {
            return await _context.PasswordResetTokens
                .FirstOrDefaultAsync(t =>
                    t.UserId == userId &&
                    t.ResetCode == resetCode &&
                    !t.IsUsed &&
                    t.ExpiryDate > DateTime.UtcNow);
        }

        public async Task AddAsync(PasswordResetToken token)
        {
            await _context.PasswordResetTokens.AddAsync(token);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PasswordResetToken token)
        {
            _context.PasswordResetTokens.Update(token);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteExpiredTokensAsync()
        {
            var expiredTokens = await _context.PasswordResetTokens
                .Where(t => t.ExpiryDate < DateTime.UtcNow)
                .ToListAsync();

            _context.PasswordResetTokens.RemoveRange(expiredTokens);
            await _context.SaveChangesAsync();
        }
    }
}