using WeightTracker.Domain.Entities;

namespace WeightTracker.Domain.IRepositories
{
    public interface IRecordRepository
    {
        Task<Records?> GetByIdAsync(Guid recordId);
        Task<IEnumerable<Records>> GetByUserIdAsync(Guid userId);
        Task<IEnumerable<Records>> GetByUserIdAndDateRangeAsync(Guid userId, DateTime startDate, DateTime endDate);
        Task<Records?> GetByUserIdAndDateAsync(Guid userId, DateTime date);
        Task<Records> AddAsync(Records record);
        Task<Records> UpdateAsync(Records record);
        Task<bool> DeleteAsync(Guid recordId);
        Task<IEnumerable<Records>> GetAllAsync();
    }
}