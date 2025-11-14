using Microsoft.EntityFrameworkCore;
using WeigtTracker.Domain.Entities;
using WeightTracker.Domain.IRepositories;
using WeightTracker.Infrastructure.Context;

namespace WeightTracker.Infrastructure.Repositories
{
    public class RecordRepository : IRecordRepository
    {
        private readonly WeightTrackerDbContext _context;

        public RecordRepository(WeightTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<Records?> GetByIdAsync(int recordId)
        {
            return await _context.Records
                .Include(r => r.User)
                .FirstOrDefaultAsync(r => r.RecordId == recordId && r.DeletedAt == null);
        }

        public async Task<IEnumerable<Records>> GetByUserIdAsync(int userId)
        {
            return await _context.Records
                .Where(r => r.UserId == userId && r.DeletedAt == null)
                .OrderByDescending(r => r.RecordDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Records>> GetByUserIdAndDateRangeAsync(int userId, DateTime startDate, DateTime endDate)
        {
            return await _context.Records
                .Where(r => r.UserId == userId
                    && r.RecordDate >= startDate
                    && r.RecordDate <= endDate
                    && r.DeletedAt == null)
                .OrderBy(r => r.RecordDate)
                .ToListAsync();
        }

        public async Task<Records?> GetByUserIdAndDateAsync(int userId, DateTime date)
        {
            var dateOnly = date.Date;
            return await _context.Records
                .FirstOrDefaultAsync(r => r.UserId == userId
                    && r.RecordDate.Date == dateOnly
                    && r.DeletedAt == null);
        }

        public async Task<Records> AddAsync(Records record)
        {
            record.CreatedAt = DateTime.UtcNow;
            _context.Records.Add(record);
            await _context.SaveChangesAsync();
            return record;
        }

        public async Task<Records> UpdateAsync(Records record)
        {
            record.UpdatedAt = DateTime.UtcNow;
            _context.Records.Update(record);
            await _context.SaveChangesAsync();
            return record;
        }

        public async Task<bool> DeleteAsync(int recordId)
        {
            var record = await GetByIdAsync(recordId);
            if (record == null) return false;

            record.DeletedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Records>> GetAllAsync()
        {
            return await _context.Records
                .Include(r => r.User)
                .Where(r => r.DeletedAt == null)
                .OrderByDescending(r => r.RecordDate)
                .ToListAsync();
        }
    }
}