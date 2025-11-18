using WeigtTracker.Domain.Entities;

namespace WeightTracker.Application.IServices
{
    public interface IRecordService
    {
        public Task<Records?> GetByIdAsync(int recordId);
        public Task<IEnumerable<Records>> GetByUserIdAsync(int userId);
        public Task<Records?> GetByUserIdAndDateAsync(int userId, DateTime date);
        public Task<Records> AddAsync(Records record);
        public Task<Records> UpdateAsync(Records record);
        public Task<bool> DeleteAsync(int recordId);
        public Task<IEnumerable<Records>> GetAllAsync();
        public Task<IEnumerable<Records>> GetByUserIdAndDateRangeAsync(int userId, DateTime startDate, DateTime endDate);
    }
}