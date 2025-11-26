using System.Net.Http.Json;
using WeightTracker.Domain.Entities;

namespace WeightTracker.Client.Services;

public class AdminService
{
    private readonly HttpClient _httpClient;
    
    public AdminService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<Users>?> GetAllUsersAsync()
    {
        var response = await _httpClient.GetAsync("api/Admin/users");
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<Users>>();
        }
        return null;
    }

    public async Task<Users?> GetUserByIdAsync(int id)
    {
        var response = await _httpClient.GetAsync($"api/Admin/users/{id}");
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<Users>();
        }

        return null;
    }

    public async Task<bool> DeactivateUserAsync(Guid userId)
    {
        var response = await _httpClient.PostAsync($"api/Admin/users/{userId}/deactivate", null);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> ActivateUserAsync(Guid userId)
    {
        var response = await _httpClient.PostAsync($"api/Admin/users/{userId}/activate", null);
        return response.IsSuccessStatusCode;
    }
}