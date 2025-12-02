using System;

namespace WeightTracker.Domain.Entities
{
    /// <summary>
    /// Tracks application and database versions
    /// </summary>
    public class VersionInfo
    {
        public int VersionInfoId { get; set; }
        
        /// <summary>
        /// Application version (e.g., 1.0.0.142)
        /// </summary>
        public string ApplicationVersion { get; set; } = string.Empty;
        
        /// <summary>
        /// Database schema version (migration name)
        /// </summary>
        public string DatabaseVersion { get; set; } = string.Empty;
        
        /// <summary>
        /// When this version was deployed
        /// </summary>
        public DateTime DeployedAt { get; set; }
        
        /// <summary>
        /// Environment (Production, Development, etc.)
        /// </summary>
        public string Environment { get; set; } = string.Empty;
        
        /// <summary>
        /// Build number from CI/CD
        /// </summary>
        public int BuildNumber { get; set; }
        
        /// <summary>
        /// Git commit SHA
        /// </summary>
        public string? CommitSha { get; set; }
        
        /// <summary>
        /// Host machine name
        /// </summary>
        public string? HostName { get; set; }
        
        /// <summary>
        /// Additional notes about this deployment
        /// </summary>
        public string? Notes { get; set; }
    }
}
