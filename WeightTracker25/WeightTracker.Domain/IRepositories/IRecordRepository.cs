using WeigtTracker.Domain.Entities;

namespace WeightTracker.Domain.IRepositories
{
    public interface IRecordRepository
    {
        Task<Records?> GetByIdAsync(int recordId);
        Task<IEnumerable<Records>> GetByUserIdAsync(int userId);
        Task<IEnumerable<Records>> GetByUserIdAndDateRangeAsync(int userId, DateTime startDate, DateTime endDate);
        Task<Records?> GetByUserIdAndDateAsync(int userId, DateTime date);
        Task<Records> AddAsync(Records record);
        Task<Records> UpdateAsync(Records record);
        Task<bool> DeleteAsync(int recordId);
        Task<IEnumerable<Records>> GetAllAsync();
    }
}