using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WeightTracker.Infrastructure.Services
{
    /// <summary>
    /// Service for creating and managing database backups before migrations
    /// </summary>
    public class DatabaseBackupService
    {
        private readonly ILogger<DatabaseBackupService> _logger;
        private readonly string _backupDirectory;

        public DatabaseBackupService(ILogger<DatabaseBackupService> logger, string? backupDirectory = null)
        {
            _logger = logger;
            _backupDirectory = backupDirectory ?? Path.Combine(AppContext.BaseDirectory, "backups");
            
            // Ensure backup directory exists
            if (!Directory.Exists(_backupDirectory))
            {
                Directory.CreateDirectory(_backupDirectory);
                _logger.LogInformation($"Created backup directory: {_backupDirectory}");
            }
        }

        /// <summary>
        /// Creates a backup of the SQLite database file
        /// </summary>
        public async Task<BackupResult> CreateBackupAsync(string databasePath, string? customName = null)
        {
            var result = new BackupResult();
            
            try
            {
                if (!File.Exists(databasePath))
                {
                    _logger.LogWarning($"Database file not found: {databasePath}");
                    result.Success = false;
                    result.ErrorMessage = "Database file does not exist";
                    return result;
                }

                var timestamp = DateTime.UtcNow.ToString("yyyyMMdd_HHmmss");
                var backupFileName = customName ?? $"weightTracker_backup_{timestamp}.db";
                var backupPath = Path.Combine(_backupDirectory, backupFileName);

                _logger.LogInformation($"Creating database backup: {backupPath}");

                // Copy the database file
                await Task.Run(() => File.Copy(databasePath, backupPath, overwrite: false));

                result.Success = true;
                result.BackupPath = backupPath;
                result.BackupSize = new FileInfo(backupPath).Length;
                result.Timestamp = DateTime.UtcNow;

                _logger.LogInformation($"Backup created successfully: {backupPath} ({result.BackupSize} bytes)");

                // Clean up old backups (keep last 10)
                await CleanupOldBackupsAsync(10);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating database backup");
                result.Success = false;
                result.ErrorMessage = ex.Message;
                result.Exception = ex;
                return result;
            }
        }

        /// <summary>
        /// Restores a database from a backup file
        /// </summary>
        public async Task<bool> RestoreBackupAsync(string backupPath, string targetDatabasePath)
        {
            try
            {
                if (!File.Exists(backupPath))
                {
                    _logger.LogError($"Backup file not found: {backupPath}");
                    return false;
                }

                _logger.LogInformation($"Restoring database from backup: {backupPath}");

                // Create a backup of the current database before restoring
                if (File.Exists(targetDatabasePath))
                {
                    var preRestoreBackup = $"{targetDatabasePath}.pre-restore.{DateTime.UtcNow:yyyyMMddHHmmss}";
                    File.Copy(targetDatabasePath, preRestoreBackup, overwrite: true);
                    _logger.LogInformation($"Created pre-restore backup: {preRestoreBackup}");
                }

                // Restore the backup
                await Task.Run(() => File.Copy(backupPath, targetDatabasePath, overwrite: true));

                _logger.LogInformation("Database restored successfully");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error restoring database backup");
                return false;
            }
        }

        /// <summary>
        /// Lists all available backups
        /// </summary>
        public List<BackupInfo> ListBackups()
        {
            var backups = new List<BackupInfo>();

            try
            {
                var files = Directory.GetFiles(_backupDirectory, "*.db");
                
                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    backups.Add(new BackupInfo
                    {
                        FileName = fileInfo.Name,
                        FilePath = fileInfo.FullName,
                        Size = fileInfo.Length,
                        CreatedDate = fileInfo.CreationTimeUtc
                    });
                }

                backups = backups.OrderByDescending(b => b.CreatedDate).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error listing backups");
            }

            return backups;
        }

        /// <summary>
        /// Cleans up old backup files, keeping only the specified number of most recent backups
        /// </summary>
        private async Task CleanupOldBackupsAsync(int keepCount)
        {
            try
            {
                var backups = ListBackups();
                
                if (backups.Count <= keepCount)
                {
                    return;
                }

                var backupsToDelete = backups.Skip(keepCount).ToList();
                
                foreach (var backup in backupsToDelete)
                {
                    _logger.LogInformation($"Deleting old backup: {backup.FileName}");
                    await Task.Run(() => File.Delete(backup.FilePath));
                }

                _logger.LogInformation($"Cleaned up {backupsToDelete.Count} old backup(s)");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error cleaning up old backups");
            }
        }

        /// <summary>
        /// Deletes a specific backup file
        /// </summary>
        public bool DeleteBackup(string backupPath)
        {
            try
            {
                if (File.Exists(backupPath))
                {
                    File.Delete(backupPath);
                    _logger.LogInformation($"Deleted backup: {backupPath}");
                    return true;
                }
                
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting backup: {backupPath}");
                return false;
            }
        }
    }

    /// <summary>
    /// Result of a backup operation
    /// </summary>
    public class BackupResult
    {
        public bool Success { get; set; }
        public string BackupPath { get; set; } = string.Empty;
        public long BackupSize { get; set; }
        public DateTime Timestamp { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public Exception? Exception { get; set; }
    }

    /// <summary>
    /// Information about a backup file
    /// </summary>
    public class BackupInfo
    {
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public long Size { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
