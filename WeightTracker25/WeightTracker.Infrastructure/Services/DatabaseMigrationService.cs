using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeightTracker.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeightTracker.Infrastructure.Services
{
    /// <summary>
    /// Service responsible for managing database migrations and versioning
    /// </summary>
    public class DatabaseMigrationService
    {
        private readonly WeightTrackerDbContext _context;
        private readonly ILogger<DatabaseMigrationService> _logger;

        public DatabaseMigrationService(
            WeightTrackerDbContext context,
            ILogger<DatabaseMigrationService> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Applies all pending migrations to the database and records version info
        /// </summary>
        public async Task<MigrationResult> MigrateAsync(string? applicationVersion = null, int buildNumber = 0, string? commitSha = null)
        {
            var result = new MigrationResult();
            
            try
            {
                _logger.LogInformation("Starting database migration process...");

                // Check if database exists
                var canConnect = await _context.Database.CanConnectAsync();
                if (!canConnect)
                {
                    _logger.LogWarning("Database does not exist. It will be created.");
                    result.WasCreated = true;
                }

                // Get pending migrations
                var pendingMigrations = await _context.Database.GetPendingMigrationsAsync();
                result.PendingMigrations = pendingMigrations.ToList();

                if (result.PendingMigrations.Any())
                {
                    _logger.LogInformation($"Found {result.PendingMigrations.Count} pending migration(s):");
                    foreach (var migration in result.PendingMigrations)
                    {
                        _logger.LogInformation($"  - {migration}");
                    }

                    // Apply migrations
                    await _context.Database.MigrateAsync();
                    
                    _logger.LogInformation("All migrations applied successfully.");
                    result.Success = true;
                    result.AppliedMigrations = result.PendingMigrations;
                }
                else
                {
                    _logger.LogInformation("Database is up to date. No pending migrations.");
                    result.Success = true;
                }

                // Get current applied migrations
                var appliedMigrations = await _context.Database.GetAppliedMigrationsAsync();
                result.CurrentVersion = appliedMigrations.LastOrDefault() ?? "None";
                result.TotalAppliedMigrations = appliedMigrations.Count();

                _logger.LogInformation($"Current database version: {result.CurrentVersion}");
                _logger.LogInformation($"Total applied migrations: {result.TotalAppliedMigrations}");

                // Record version info in database
                await RecordVersionInfoAsync(applicationVersion, result.CurrentVersion, buildNumber, commitSha);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during database migration.");
                result.Success = false;
                result.ErrorMessage = ex.Message;
                result.Exception = ex;
                throw;
            }
        }

        /// <summary>
        /// Records version information in the database
        /// </summary>
        private async Task RecordVersionInfoAsync(string? applicationVersion, string databaseVersion, int buildNumber, string? commitSha)
        {
            try
            {
                var versionInfo = new WeightTracker.Domain.Entities.VersionInfo
                {
                    ApplicationVersion = applicationVersion ?? "1.0.0.0",
                    DatabaseVersion = databaseVersion,
                    DeployedAt = DateTime.UtcNow,
                    Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production",
                    BuildNumber = buildNumber,
                    CommitSha = commitSha,
                    HostName = Environment.MachineName,
                    Notes = $"Deployment with {(string.IsNullOrEmpty(applicationVersion) ? "unknown" : applicationVersion)} app version"
                };

                _context.VersionHistory.Add(versionInfo);
                await _context.SaveChangesAsync();
                
                _logger.LogInformation($"Version info recorded: App={applicationVersion}, DB={databaseVersion}, Build={buildNumber}");
            }
            catch (Exception ex)
            {
                // Don't fail the migration if version recording fails
                _logger.LogWarning(ex, "Failed to record version info in database");
            }
        }

        /// <summary>
        /// Gets the current version information from the database
        /// </summary>
        public async Task<WeightTracker.Domain.Entities.VersionInfo?> GetCurrentVersionAsync()
        {
            try
            {
                return await _context.VersionHistory
                    .OrderByDescending(v => v.DeployedAt)
                    .FirstOrDefaultAsync();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets version history from the database
        /// </summary>
        public async Task<List<WeightTracker.Domain.Entities.VersionInfo>> GetVersionHistoryAsync(int count = 10)
        {
            try
            {
                return await _context.VersionHistory
                    .OrderByDescending(v => v.DeployedAt)
                    .Take(count)
                    .ToListAsync();
            }
            catch
            {
                return new List<WeightTracker.Domain.Entities.VersionInfo>();
            }
        }

        /// <summary>
        /// Gets information about the current database state
        /// </summary>
        public async Task<DatabaseInfo> GetDatabaseInfoAsync()
        {
            var info = new DatabaseInfo();

            try
            {
                info.CanConnect = await _context.Database.CanConnectAsync();
                
                if (info.CanConnect)
                {
                    var appliedMigrations = await _context.Database.GetAppliedMigrationsAsync();
                    info.AppliedMigrations = appliedMigrations.ToList();
                    
                    var pendingMigrations = await _context.Database.GetPendingMigrationsAsync();
                    info.PendingMigrations = pendingMigrations.ToList();

                    info.CurrentVersion = appliedMigrations.LastOrDefault() ?? "None";
                    info.IsUpToDate = !pendingMigrations.Any();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving database information.");
                info.ErrorMessage = ex.Message;
            }

            return info;
        }

        /// <summary>
        /// Validates that the database schema matches the current model
        /// </summary>
        public async Task<bool> ValidateDatabaseSchemaAsync()
        {
            try
            {
                // This will throw if the database doesn't match the model
                var pendingMigrations = await _context.Database.GetPendingMigrationsAsync();
                return !pendingMigrations.Any();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Database schema validation failed.");
                return false;
            }
        }
    }

    /// <summary>
    /// Result of a migration operation
    /// </summary>
    public class MigrationResult
    {
        public bool Success { get; set; }
        public bool WasCreated { get; set; }
        public string CurrentVersion { get; set; } = string.Empty;
        public int TotalAppliedMigrations { get; set; }
        public List<string> PendingMigrations { get; set; } = new();
        public List<string> AppliedMigrations { get; set; } = new();
        public string ErrorMessage { get; set; } = string.Empty;
        public Exception? Exception { get; set; }
    }

    /// <summary>
    /// Information about the current database state
    /// </summary>
    public class DatabaseInfo
    {
        public bool CanConnect { get; set; }
        public bool IsUpToDate { get; set; }
        public string CurrentVersion { get; set; } = string.Empty;
        public List<string> AppliedMigrations { get; set; } = new();
        public List<string> PendingMigrations { get; set; } = new();
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
