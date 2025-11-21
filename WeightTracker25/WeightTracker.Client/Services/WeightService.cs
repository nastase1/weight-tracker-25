using WeightTracker.Client.Models;
using System.Net.Http.Json;
using WeightTracker.Domain.Entities;
using WeightTracker.Shared.DTOs.Requests;

namespace WeightTracker.Client.Services;

public class WeightService
{
    private readonly HttpClient _httpClient;
    private readonly AuthService _authService;

    public WeightService(HttpClient httpClient, AuthService authService)
    {
        _httpClient = httpClient;
        _authService = authService;
    }

    public async Task<List<WeightEntry>> GetWeightEntriesAsync()
    {
        try
        {
            var userId = await _authService.GetUserIdAsync();
            if (!userId.HasValue)
            {
                return new List<WeightEntry>();
            }

            var response = await _httpClient.GetAsync($"api/Records/user/{userId.Value}");
            if (!response.IsSuccessStatusCode)
            {
                return new List<WeightEntry>();
            }

            var records = await response.Content.ReadFromJsonAsync<List<Records>>();
            if (records == null)
            {
                return new List<WeightEntry>();
            }

            return records.Select(r => new WeightEntry
            {
                Id = 0,
                Date = r.RecordDate,
                Weight = r.Weight,
                Notes = null,
                UserId = r.UserId.ToString()
            }).ToList();
        }
        catch
        {
            return new List<WeightEntry>();
        }
    }

    public async Task<WeightEntry?> GetWeightEntryByDateAsync(DateTime date)
    {
        var entries = await GetWeightEntriesAsync();
        return entries.FirstOrDefault(e => e.Date.Date == date.Date);
    }

    public async Task<WeightEntry> SaveWeightEntryAsync(WeightEntry entry)
    {
        try
        {
            var userId = await _authService.GetUserIdAsync();
            if (!userId.HasValue)
            {
                throw new InvalidOperationException("User not authenticated");
            }

            var existingRecordResponse = await _httpClient.GetAsync($"api/Records/user/{userId.Value}/date/{entry.Date:yyyy-MM-dd}");
            
            if (existingRecordResponse.IsSuccessStatusCode)
            {
                var existingRecord = await existingRecordResponse.Content.ReadFromJsonAsync<Records>();
                if (existingRecord != null)
                {
                    var updateRequest = new UpdateRecordRequest
                    {
                        RecordDate = entry.Date,
                        Weight = entry.Weight,
                        Height = existingRecord.Height
                    };

                    var updateResponse = await _httpClient.PutAsJsonAsync($"api/Records/{existingRecord.RecordId}", updateRequest);
                    updateResponse.EnsureSuccessStatusCode();
                }
            }
            else
            {
                var createRequest = new CreateRecordRequest
                {
                    UserId = userId.Value,
                    RecordDate = entry.Date,
                    Weight = entry.Weight,
                    Height = 170
                };

                var createResponse = await _httpClient.PostAsJsonAsync("api/Records", createRequest);
                createResponse.EnsureSuccessStatusCode();
            }

            return entry;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving weight entry: {ex.Message}");
            throw;
        }
    }

    public async Task DeleteWeightEntryAsync(DateTime date)
    {
        try
        {
            var userId = await _authService.GetUserIdAsync();
            if (!userId.HasValue)
            {
                throw new InvalidOperationException("User not authenticated");
            }

            var recordResponse = await _httpClient.GetAsync($"api/Records/user/{userId.Value}/date/{date:yyyy-MM-dd}");
            if (recordResponse.IsSuccessStatusCode)
            {
                var record = await recordResponse.Content.ReadFromJsonAsync<Records>();
                if (record != null)
                {
                    var deleteResponse = await _httpClient.DeleteAsync($"api/Records/{record.RecordId}");
                    deleteResponse.EnsureSuccessStatusCode();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting weight entry: {ex.Message}");
            throw;
        }
    }

    public async Task<WeightStats> GetWeightStatsAsync()
    {
        var entries = await GetWeightEntriesAsync();
        entries = entries.OrderBy(e => e.Date).ToList();

        if (!entries.Any())
        {
            return new WeightStats();
        }

        var latestEntry = entries.Last();
        var previousEntry = entries.Count > 1 ? entries[entries.Count - 2] : null;
        var startingEntry = entries.First();

        return new WeightStats
        {
            CurrentWeight = latestEntry.Weight,
            PreviousWeight = previousEntry?.Weight,
            StartingWeight = startingEntry.Weight,
            TotalEntries = entries.Count,
            LastEntry = latestEntry.Date
        };
    }

    public async Task<List<ChartDataPoint>> GetChartDataAsync()
    {
        var entries = await GetWeightEntriesAsync();
        return entries
            .OrderBy(e => e.Date)
            .Select(e => new ChartDataPoint { Date = e.Date, Weight = e.Weight })
            .ToList();
    }
}