using WeightTracker.Application.IServices;
using WeightTracker.Domain.IRepositories;
using WeightTracker.Domain.Entities;

namespace WeightTracker.Application.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;
        public RecordService(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public async Task<Records?> GetByIdAsync(Guid recordId)
        {
            return await _recordRepository.GetByIdAsync(recordId);
        }

        public async Task<IEnumerable<Records>> GetByUserIdAsync(Guid userId)
        {
            return await _recordRepository.GetByUserIdAsync(userId);
        }

        public async Task<Records?> GetByUserIdAndDateAsync(Guid userId, DateTime date)
        {
            return await _recordRepository.GetByUserIdAndDateAsync(userId, date);
        }

        public async Task<Records> AddAsync(Records record)
        {
            return await _recordRepository.AddAsync(record);
        }

        public async Task<Records> UpdateAsync(Records record)
        {
            return await _recordRepository.UpdateAsync(record);
        }

        public async Task<bool> DeleteAsync(Guid recordId)
        {
            return await _recordRepository.DeleteAsync(recordId);
        }

        public async Task<IEnumerable<Records>> GetAllAsync()
        {
            return await _recordRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Records>> GetByUserIdAndDateRangeAsync(Guid userId, DateTime startDate, DateTime endDate)
        {
            return await _recordRepository.GetByUserIdAndDateRangeAsync(userId, startDate, endDate);
        }
    }
}
