using Microsoft.AspNetCore.Mvc;
using WeightTracker.Infrastructure.Services;

namespace WeightTracker.API.Controllers
{
    /// <summary>
    /// Controller for database migration and version management
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly DatabaseMigrationService _migrationService;
        private readonly DatabaseBackupService _backupService;
        private readonly ILogger<DatabaseController> _logger;
        private readonly IConfiguration _configuration;

        public DatabaseController(
            DatabaseMigrationService migrationService,
            DatabaseBackupService backupService,
            ILogger<DatabaseController> logger,
            IConfiguration configuration)
        {
            _migrationService = migrationService;
            _backupService = backupService;
            _logger = logger;
            _configuration = configuration;
        }

        /// <summary>
        /// Gets current database version and migration status
        /// </summary>
        [HttpGet("info")]
        public async Task<IActionResult> GetDatabaseInfo()
        {
            try
            {
                var info = await _migrationService.GetDatabaseInfoAsync();
                var currentVersion = await _migrationService.GetCurrentVersionAsync();
                
                return Ok(new
                {
                    database = info,
                    currentVersion = currentVersion != null ? new
                    {
                        currentVersion.ApplicationVersion,
                        currentVersion.DatabaseVersion,
                        currentVersion.DeployedAt,
                        currentVersion.Environment,
                        currentVersion.BuildNumber,
                        currentVersion.CommitSha,
                        currentVersion.HostName
                    } : null
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving database information");
                return StatusCode(500, new { error = "Failed to retrieve database information", details = ex.Message });
            }
        }

        /// <summary>
        /// Gets version history from the database
        /// </summary>
        [HttpGet("version-history")]
        public async Task<IActionResult> GetVersionHistory([FromQuery] int count = 10)
        {
            try
            {
                var history = await _migrationService.GetVersionHistoryAsync(count);
                return Ok(history);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving version history");
                return StatusCode(500, new { error = "Failed to retrieve version history", details = ex.Message });
            }
        }

        /// <summary>
        /// Gets list of available database backups
        /// </summary>
        [HttpGet("backups")]
        public IActionResult GetBackups()
        {
            try
            {
                var backups = _backupService.ListBackups();
                return Ok(backups);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving backup list");
                return StatusCode(500, new { error = "Failed to retrieve backup list", details = ex.Message });
            }
        }

        /// <summary>
        /// Creates a manual backup of the database
        /// </summary>
        [HttpPost("backup")]
        public async Task<IActionResult> CreateBackup([FromQuery] string? name = null)
        {
            try
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                var dbPath = connectionString?.Replace("Data Source=", "").Trim() ?? "weightTracker.db";
                
                if (!Path.IsPathRooted(dbPath))
                {
                    dbPath = Path.Combine(AppContext.BaseDirectory, dbPath);
                }

                var result = await _backupService.CreateBackupAsync(dbPath, name);
                
                if (result.Success)
                {
                    return Ok(new 
                    { 
                        message = "Backup created successfully",
                        backupPath = result.BackupPath,
                        size = result.BackupSize,
                        timestamp = result.Timestamp
                    });
                }
                else
                {
                    return BadRequest(new { error = "Backup failed", details = result.ErrorMessage });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating backup");
                return StatusCode(500, new { error = "Failed to create backup", details = ex.Message });
            }
        }

        /// <summary>
        /// Validates the database schema
        /// </summary>
        [HttpGet("validate")]
        public async Task<IActionResult> ValidateSchema()
        {
            try
            {
                var isValid = await _migrationService.ValidateDatabaseSchemaAsync();
                return Ok(new { isValid, message = isValid ? "Database schema is valid" : "Database schema is out of date" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error validating database schema");
                return StatusCode(500, new { error = "Failed to validate schema", details = ex.Message });
            }
        }
    }
}
