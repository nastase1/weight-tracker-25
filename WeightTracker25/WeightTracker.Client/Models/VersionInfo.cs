namespace WeightTracker.Client.Models;

public class VersionInfo
{
    public string Version { get; set; } = string.Empty;
    public string BuildDate { get; set; } = string.Empty;
    public string Environment { get; set; } = string.Empty;
}

public class DatabaseInfo
{
    public bool IsAvailable { get; set; }
    public string ConnectionString { get; set; } = string.Empty;
    public bool PendingMigrations { get; set; }
    public VersionHistory? CurrentVersion { get; set; }
}

public class VersionHistory
{
    public string ApplicationVersion { get; set; } = string.Empty;
    public string DatabaseVersion { get; set; } = string.Empty;
    public DateTime DeployedAt { get; set; }
    public string Environment { get; set; } = string.Empty;
    public int BuildNumber { get; set; }
    public string? CommitSha { get; set; }
}
