using WeightTracker.Domain.Entities;

namespace WeightTracker.Application.IServices
{
    public interface IRecordService
    {
        public Task<Records?> GetByIdAsync(Guid recordId);
        public Task<IEnumerable<Records>> GetByUserIdAsync(Guid userId);
        public Task<Records?> GetByUserIdAndDateAsync(Guid userId, DateTime date);
        public Task<Records> AddAsync(Records record);
        public Task<Records> UpdateAsync(Records record);
        public Task<bool> DeleteAsync(Guid recordId);
        public Task<IEnumerable<Records>> GetAllAsync();
        public Task<IEnumerable<Records>> GetByUserIdAndDateRangeAsync(Guid userId, DateTime startDate, DateTime endDate);
    }
}