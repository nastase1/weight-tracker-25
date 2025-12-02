using WeightTracker.Application.IServices;
using WeightTracker.Domain.IRepositories;
using WeightTracker.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace WeightTracker.Application.Services
{
    public class CleanupService : ICleanupService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRecordRepository _recordRepository;
        private readonly ILogger<CleanupService> _logger;
        private const int DELETION_DAYS = 90;

        public CleanupService(
            IUserRepository userRepository, 
            IRecordRepository recordRepository,
            ILogger<CleanupService> logger)
        {
            _userRepository = userRepository;
            _recordRepository = recordRepository;
            _logger = logger;
        }

        public async Task CleanupExpiredUsersAsync()
        {
            try
            {
                _logger.LogInformation("Starting cleanup of expired deactivated users...");

                var cutoffDate = DateTime.UtcNow.AddDays(-DELETION_DAYS);
                var expiredUsers = await GetExpiredDeactivatedUsers(cutoffDate);

                foreach (var user in expiredUsers)
                {
                    await DeleteUserAndData(user);
                    _logger.LogInformation("Permanently deleted user {UserId} ({Email}) and all associated data", 
                        user.UserId, user.Email);
                }

                _logger.LogInformation("Cleanup completed. Deleted {Count} expired users", expiredUsers.Count());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during cleanup of expired users");
                throw;
            }
        }

        private async Task<IEnumerable<Users>> GetExpiredDeactivatedUsers(DateTime cutoffDate)
        {
            var allUsers = await _userRepository.GetAllUsersIncludingInactiveAsync();
            return allUsers.Where(u => 
                u.DeletedAt.HasValue && 
                u.DeletedAt.Value <= cutoffDate &&
                !u.IsAdmin); // Never auto-delete admin accounts
        }

        private async Task DeleteUserAndData(Users user)
        {
            // First delete all user records
            var userRecords = await _recordRepository.GetAllByUserIdAsync(user.UserId);
            foreach (var record in userRecords)
            {
                await _recordRepository.DeleteAsync(record.RecordId);
            }

            // Then delete the user permanently
            await _userRepository.PermanentDeleteAsync(user.UserId);
        }
    }
}