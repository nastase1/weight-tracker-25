using Blazored.LocalStorage;
using WeightTracker.Client.Models;
using System.Net.Http.Json;

namespace WeightTracker.Client.Services;

public class WeightService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _localStorage;
    private const string STORAGE_KEY = "weight_entries";

    public WeightService(HttpClient httpClient, ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _localStorage = localStorage;
    }

    public async Task<List<WeightEntry>> GetWeightEntriesAsync()
    {
        try
        {
            // For demo purposes, we'll use local storage
            // In a real app, this would call your API
            var entries = await _localStorage.GetItemAsync<List<WeightEntry>>(STORAGE_KEY);
            return entries ?? new List<WeightEntry>();
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
        var entries = await GetWeightEntriesAsync();
        
        var existingEntry = entries.FirstOrDefault(e => e.Date.Date == entry.Date.Date);
        if (existingEntry != null)
        {
            existingEntry.Weight = entry.Weight;
            existingEntry.Notes = entry.Notes;
        }
        else
        {
            entry.Id = entries.Any() ? entries.Max(e => e.Id) + 1 : 1;
            entries.Add(entry);
        }

        await _localStorage.SetItemAsync(STORAGE_KEY, entries);
        return entry;
    }

    public async Task DeleteWeightEntryAsync(int id)
    {
        var entries = await GetWeightEntriesAsync();
        var entryToRemove = entries.FirstOrDefault(e => e.Id == id);
        if (entryToRemove != null)
        {
            entries.Remove(entryToRemove);
            await _localStorage.SetItemAsync(STORAGE_KEY, entries);
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