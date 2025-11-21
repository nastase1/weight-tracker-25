using Blazored.LocalStorage;
using WeightTracker.Client.Models;
using System.Net.Http.Json;
using WeightTracker.Shared.DTOs.Responses.User;
using WeightTracker.Shared.DTOs.Requests.User;

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

    public async Task<UserLoginResponseDTO> LoginAsync(LoginRequest request)
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

                return new UserLoginResponseDTO
                {
                    Success = true,
                    Message = "Login successful",
                    Token = token
                };
            }
            else
            {
                var loginDto = new UserLoginRequestDTO
                {
                    Email = request.Email,
                    Password = request.Password,
                    RememberMe = request.RememberMe
                };

                var response = await _httpClient.PostAsJsonAsync("api/Authentification/login", loginDto);
                
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = await response.Content.ReadFromJsonAsync<UserLoginResponseDTO>();
                    
                    if (apiResponse != null && apiResponse.Success && !string.IsNullOrEmpty(apiResponse.Token))
                    {
                        await _localStorage.SetItemAsync(TOKEN_KEY, apiResponse.Token);
                        
                        // Create a basic user object from the email
                        var user = new User
                        {
                            Id = Guid.NewGuid().ToString(), // Temporary ID
                            Email = request.Email,
                            Name = request.Email.Split('@')[0],
                            DateJoined = DateTime.Now
                        };
                        await _localStorage.SetItemAsync(USER_KEY, user);
                        
                        await SetAuthorizationHeaderAsync();
                        AuthenticationStateChanged?.Invoke(true);
                        
                        return new UserLoginResponseDTO
                        {
                            Success = true,
                            Message = apiResponse.Message ?? "Login successful",
                            Token = apiResponse.Token
                        };
                    }
                    else
                    {
                        return new UserLoginResponseDTO
                        {
                            Success = false,
                            Message = apiResponse?.Message ?? "Invalid response from server",
                            Token = null
                        };
                    }
                }
                else
                {
                    var apiResponse = await response.Content.ReadFromJsonAsync<UserLoginResponseDTO>();
                    return new UserLoginResponseDTO
                    {
                        Success = false,
                        Message = apiResponse?.Message ?? $"Login failed: {response.StatusCode}",
                        Token = null
                    };
                }
            }
        }
        catch (Exception ex)
        {
            return new UserLoginResponseDTO
            {
                Success = false,
                Message = ex.Message,
                Token = null
            };
        }
    }

    public async Task<AuthResponse> RegisterAsync(RegisterRequest request)
    {
        try
        {
            if (request.Password != request.ConfirmPassword)
            {
                return new AuthResponse
                {
                    Success = false,
                    Message = "Passwords do not match"
                };
            }

            var registerDto = new UserRegisterRequestDTO
            {
                Email = request.Email,
                Username = request.Name,
                Password = request.Password
            };

            var response = await _httpClient.PostAsJsonAsync("api/Authentification/register", registerDto);
            
            if (response.IsSuccessStatusCode)
            {
                var apiResponse = await response.Content.ReadFromJsonAsync<UserRegisterResponseDTO>();
                
                if (apiResponse != null && apiResponse.Success)
                {
                    // After successful registration, automatically log in
                    var loginResult = await LoginAsync(new LoginRequest
                    {
                        Email = request.Email,
                        Password = request.Password,
                        RememberMe = false
                    });

                    if (loginResult.Success)
                    {
                        var user = new User
                        {
                            Id = Guid.NewGuid().ToString(),
                            Email = request.Email,
                            Name = request.Name,
                            DateJoined = DateTime.Now
                        };

                        return new AuthResponse
                        {
                            Success = true,
                            Message = "Registration successful",
                            Token = loginResult.Token,
                            User = user
                        };
                    }
                    else
                    {
                        return new AuthResponse
                        {
                            Success = true,
                            Message = "Registration successful. Please login.",
                            Token = null,
                            User = null
                        };
                    }
                }
                else
                {
                    return new AuthResponse
                    {
                        Success = false,
                        Message = apiResponse?.Message ?? "Registration failed"
                    };
                }
            }
            else
            {
                var apiResponse = await response.Content.ReadFromJsonAsync<UserRegisterResponseDTO>();
                return new AuthResponse
                {
                    Success = false,
                    Message = apiResponse?.Message ?? $"Registration failed: {response.StatusCode}"
                };
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

    public async Task LogoutAsync()
    {
        await _localStorage.RemoveItemAsync(TOKEN_KEY);
        await _localStorage.RemoveItemAsync(USER_KEY);
        _httpClient.DefaultRequestHeaders.Authorization = null;
        AuthenticationStateChanged?.Invoke(false);
    }
}