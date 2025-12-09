using System.Net.Http.Json;
using WeightTracker.Client.Models;

namespace WeightTracker.Client.Services;

public class VersionService
{
    private readonly HttpClient _httpClient;
    private VersionInfo? _cachedVersion;
    private DatabaseInfo? _cachedDbInfo;
    private DateTime? _lastFetch;
    private readonly TimeSpan _cacheExpiry = TimeSpan.FromMinutes(5);

    public VersionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<VersionInfo?> GetVersionAsync()
    {
        // Use cached version if available and not expired
        if (_cachedVersion != null && _lastFetch.HasValue && 
            DateTime.Now - _lastFetch.Value < _cacheExpiry)
        {
            return _cachedVersion;
        }

        try
        {
            var version = await _httpClient.GetFromJsonAsync<VersionInfo>("api/version");
            
            if (version != null)
            {
                _cachedVersion = version;
                _lastFetch = DateTime.Now;
            }
            
            return version;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching version: {ex.Message}");
            return null;
        }
    }

    public async Task<DatabaseInfo?> GetDatabaseInfoAsync()
    {
        try
        {
            var dbInfo = await _httpClient.GetFromJsonAsync<DatabaseInfo>("api/database/info");
            
            if (dbInfo != null)
            {
                _cachedDbInfo = dbInfo;
            }
            
            return dbInfo;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching database info: {ex.Message}");
            return null;
        }
    }

    public string GetShortVersion(string fullVersion)
    {
        // Convert "1.0.0.142" to "v1.0.0"
        var parts = fullVersion.Split('.');
        if (parts.Length >= 3)
        {
            return $"v{parts[0]}.{parts[1]}.{parts[2]}";
        }
        return $"v{fullVersion}";
    }
}
