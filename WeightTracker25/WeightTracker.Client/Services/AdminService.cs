using WeightTracker.Client.Models;
using System.Net.Http.Json;

namespace WeightTracker.Client.Services;

public class AdminService
{
    private readonly HttpClient _httpClient;
    
    public AdminService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<User>?> GetAllUsersAsync()
    {
        var response = await _httpClient.GetAsync("api/admin/users");
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<User>>();
        }
        return null;
    }

    public async Task<User?> GetUserByIdAsync(int id)
    {
        var response = await _httpClient.GetAsync($"api/admin/users/{id}");
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<User>();
        }

        return null;
    }
}