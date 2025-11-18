using Blazored.LocalStorage;
using WeightTracker.Client.Models;
using System.Net.Http.Json;

namespace WeightTracker.Client.Services;

public class AuthService
{
    private readonly HttpClient _httpClient;
    private readonly ILocalStorageService _localStorage;
    private const string TOKEN_KEY = "auth_token";
    private const string USER_KEY = "auth_user";

    public event Action<bool>? AuthenticationStateChanged;

    public AuthService(HttpClient httpClient, ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _localStorage = localStorage;
    }

    public async Task<bool> IsAuthenticatedAsync()
    {
        var token = await _localStorage.GetItemAsync<string>(TOKEN_KEY);
        return !string.IsNullOrEmpty(token);
    }

    public async Task<User?> GetCurrentUserAsync()
    {
        return await _localStorage.GetItemAsync<User>(USER_KEY);
    }

    public async Task<AuthResponse> LoginAsync(LoginRequest request)
    {
        try
        {
            // For demo purposes, we'll simulate authentication
            // In a real app, this would call your API
            await Task.Delay(500); // Simulate API call

            if (request.Email == "demo@example.com" && request.Password == "password")
            {
                var user = new User
                {
                    Id = "1",
                    Email = request.Email,
                    Name = "Demo",
                    DateJoined = DateTime.Now.AddDays(-30)
                };

                var token = "demo_token_" + Guid.NewGuid().ToString();

                await _localStorage.SetItemAsync(TOKEN_KEY, token);
                await _localStorage.SetItemAsync(USER_KEY, user);

                AuthenticationStateChanged?.Invoke(true);

                return new AuthResponse
                {
                    Success = true,
                    Message = "Login successful",
                    Token = token,
                    User = user
                };
            }

            return new AuthResponse
            {
                Success = false,
                Message = "Invalid email or password"
            };
        }
        catch (Exception ex)
        {
            return new AuthResponse
            {
                Success = false,
                Message = ex.Message
            };
        }
    }

    public async Task<AuthResponse> RegisterAsync(RegisterRequest request)
    {
        try
        {
            // For demo purposes, we'll simulate registration
            // In a real app, this would call your API
            await Task.Delay(500); // Simulate API call

            if (request.Password != request.ConfirmPassword)
            {
                return new AuthResponse
                {
                    Success = false,
                    Message = "Passwords do not match"
                };
            }

            var user = new User
            {
                Id = Guid.NewGuid().ToString(),
                Email = request.Email,
                Name = request.Name,
                DateJoined = DateTime.Now
            };

            var token = "demo_token_" + Guid.NewGuid().ToString();

            await _localStorage.SetItemAsync(TOKEN_KEY, token);
            await _localStorage.SetItemAsync(USER_KEY, user);

            AuthenticationStateChanged?.Invoke(true);

            return new AuthResponse
            {
                Success = true,
                Message = "Registration successful",
                Token = token,
                User = user
            };
        }
        catch (Exception ex)
        {
            return new AuthResponse
            {
                Success = false,
                Message = ex.Message
            };
        }
    }

    public async Task LogoutAsync()
    {
        await _localStorage.RemoveItemAsync(TOKEN_KEY);
        await _localStorage.RemoveItemAsync(USER_KEY);
        AuthenticationStateChanged?.Invoke(false);
    }
}