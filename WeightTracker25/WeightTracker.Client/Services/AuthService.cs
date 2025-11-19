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

    public async Task InitializeAsync()
    {
        var token = await GetTokenAsync();
        if (!string.IsNullOrEmpty(token))
        {
            await SetAuthorizationHeaderAsync();
            AuthenticationStateChanged?.Invoke(true);
        }
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

    public async Task<string?> GetTokenAsync()
    {
        return await _localStorage.GetItemAsync<string>(TOKEN_KEY);
    }

    public async Task SetAuthorizationHeaderAsync()
    {
        var token = await GetTokenAsync();
        if (!string.IsNullOrEmpty(token))
        {
            _httpClient.DefaultRequestHeaders.Authorization = 
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }
        else
        {
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }

    public async Task<AuthResponse> LoginAsync(LoginRequest request)
    {
        try
        {
            // For demo purposes, we'll simulate a successful login
            if (request.Email == "demo@example.com" && request.Password == "password")
            {
                await Task.Delay(500); // Simulate API call
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

                await SetAuthorizationHeaderAsync();
                AuthenticationStateChanged?.Invoke(true);

                return new AuthResponse
                {
                    Success = true,
                    Message = "Login successful",
                    Token = token,
                    User = user
                };
            }
            else
            {
                var response = await _httpClient.PostAsJsonAsync("api/authentication/login", request);
                
                if (response.IsSuccessStatusCode)
                {
                    var authResult = await response.Content.ReadFromJsonAsync<AuthResponse>();
                    
                    if (authResult != null && authResult.Success && !string.IsNullOrEmpty(authResult.Token))
                    {
                        await _localStorage.SetItemAsync(TOKEN_KEY, authResult.Token);
                        if (authResult.User != null)
                        {
                            await _localStorage.SetItemAsync(USER_KEY, authResult.User);
                        }
                        
                        await SetAuthorizationHeaderAsync();
                        AuthenticationStateChanged?.Invoke(true);
                        
                        return authResult;
                    }
                    else
                    {
                        return new AuthResponse
                        {
                            Success = false,
                            Message = authResult?.Message ?? "Invalid response from server"
                        };
                    }
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    return new AuthResponse
                    {
                        Success = false,
                        Message = $"Login failed: {response.StatusCode} - {errorContent}"
                    };
                }
            }
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
        _httpClient.DefaultRequestHeaders.Authorization = null;
        AuthenticationStateChanged?.Invoke(false);
    }
}