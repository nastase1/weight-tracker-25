using WeightTracker.Client.Models;
using System.Net.Http.Json;
using WeightTracker.Domain.Entities;
using WeightTracker.Shared.DTOs.Requests.Record;
using System.Text.Json;
using WeightTracker.Shared.DTOs.Requests.Import;
using WeightTracker.Shared.DTOs.Responses.Import;
using Microsoft.AspNetCore.Components.Forms;

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
                UserId = r.UserId
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
                    var updateRequest = new UpdateRecordRequestDTO
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
                var createRequest = new CreateRecordRequestDTO
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
        try
        {
            var userId = await _authService.GetUserIdAsync();
            if (!userId.HasValue)
            {
                return new List<ChartDataPoint>();
            }

            var response = await _httpClient.GetAsync($"api/Records/user/{userId.Value}");
            if (!response.IsSuccessStatusCode)
            {
                return new List<ChartDataPoint>();
            }

            var records = await response.Content.ReadFromJsonAsync<List<Records>>();
            if (records == null)
            {
                return new List<ChartDataPoint>();
            }

            return records
                .OrderBy(r => r.RecordDate)
                .Select(r => new ChartDataPoint 
                { 
                    Date = r.RecordDate, 
                    Weight = r.Weight,
                    RecordId = r.RecordId
                })
                .ToList();
        }
        catch
        {
            return new List<ChartDataPoint>();
        }
    }

    public async Task UpdateWeightRecordAsync(Guid recordId, decimal newWeight, DateTime date)
    {
        try
        {
            var recordResponse = await _httpClient.GetAsync($"api/Records/{recordId}");
            if (recordResponse.IsSuccessStatusCode)
            {
                var record = await recordResponse.Content.ReadFromJsonAsync<Records>();
                if (record != null)
                {
                    var updateRequest = new UpdateRecordRequestDTO
                    {
                        RecordDate = date,
                        Weight = newWeight,
                        Height = record.Height
                    };

                    var updateResponse = await _httpClient.PutAsJsonAsync($"api/Records/{recordId}", updateRequest);
                    updateResponse.EnsureSuccessStatusCode();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating weight record: {ex.Message}");
            throw;
        }
    }

    public async Task DeleteWeightRecordAsync(Guid recordId)
    {
        try
        {
            var deleteResponse = await _httpClient.DeleteAsync($"api/Records/{recordId}");
            deleteResponse.EnsureSuccessStatusCode();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting weight record: {ex.Message}");
            throw;
        }
    }

    public async Task<ImportFormatResponseDTO> ImportWeightDataAsync(IBrowserFile file)
    {
        try
        {
            // Ensure user is authenticated and token is set
            await _authService.SetAuthorizationHeaderAsync();
            
            // Read file content
            using var stream = file.OpenReadStream(maxAllowedSize: 5 * 1024 * 1024); // 5MB limit
            using var reader = new StreamReader(stream);
            var jsonContent = await reader.ReadToEndAsync();

            if (string.IsNullOrWhiteSpace(jsonContent))
            {
                return new ImportFormatResponseDTO
                {
                    Success = false,
                    Message = "File is empty or could not be read."
                };
            }

            // Try to parse as legacy format first (with Unix timestamps)
            ImportFormatRequestDTO importRequest;
            try
            {
                importRequest = JsonSerializer.Deserialize<ImportFormatRequestDTO>(jsonContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })!;
            }
            catch
            {
                // If legacy format fails, try to parse as standard format
                var standardData = JsonSerializer.Deserialize<StandardWeightEntry[]>(jsonContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                importRequest = new ImportFormatRequestDTO
                {
                    Version = 1,
                    Settings = new List<SettingsFormatRequestDTO>(),
                    Weights = standardData?.Select(entry => new DataFormatRequestDTO
                    {
                        Date = ((DateTimeOffset)entry.Date).ToUnixTimeMilliseconds(),
                        Weight = (float)entry.Weight
                    }).ToList() ?? new List<DataFormatRequestDTO>()
                };
            }

            // Validate import data
            if (importRequest?.Weights == null || !importRequest.Weights.Any())
            {
                return new ImportFormatResponseDTO
                {
                    Success = false,
                    Message = "No valid weight data found in the file."
                };
            }

            // Send to API
            var response = await _httpClient.PostAsJsonAsync("api/Import/json", importRequest);
            
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<ImportFormatResponseDTO>();
                return result ?? new ImportFormatResponseDTO { Success = false, Message = "Invalid response from server." };
            }
            else
            {
                return new ImportFormatResponseDTO
                {
                    Success = false,
                    Message = $"Import failed: {response.ReasonPhrase}"
                };
            }
        }
        catch (Exception ex)
        {
            return new ImportFormatResponseDTO
            {
                Success = false,
                Message = $"Error importing data: {ex.Message}"
            };
        }
    }
}