using Blazored.LocalStorage;
using WeightTracker.Client.Models;
using System.Net.Http.Json;
using WeightTracker.Shared.DTOs.Responses.User;
using WeightTracker.Shared.DTOs.Requests.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

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
                    await SetAuthorizationHeaderAsync();
                    
                    try
                    {
                        var userResponse = await _httpClient.GetAsync("api/User/me");
                        if (userResponse.IsSuccessStatusCode)
                        {
                            var dbUser = await userResponse.Content.ReadFromJsonAsync<WeightTracker.Domain.Entities.Users>();
                            if (dbUser != null)
                            {
                                var user = new User
                                {
                                    Id = dbUser.UserId.ToString(),
                                    Email = dbUser.Email,
                                    Name = dbUser.Username,
                                    DateJoined = dbUser.CreatedAt
                                };
                                await _localStorage.SetItemAsync(USER_KEY, user);
                            }
                        }
                    }
                    catch
                    {
                        var userId = await GetUserIdAsync();
                        var user = new User
                        {
                            Id = userId?.ToString() ?? Guid.NewGuid().ToString(),
                            Email = request.Email,
                            Name = request.Email.Split('@')[0],
                            DateJoined = DateTime.Now
                        };
                        await _localStorage.SetItemAsync(USER_KEY, user);
                    }
                    
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
                    var loginResult = await LoginAsync(new LoginRequest
                    {
                        Email = request.Email,
                        Password = request.Password,
                        RememberMe = false
                    });

                    if (loginResult.Success)
                    {
                        var user = await GetCurrentUserAsync();
                        
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

    public async Task<Guid?> GetUserIdAsync()
    {
        try
        {
            var token = await GetTokenAsync();
            if (string.IsNullOrEmpty(token))
            {
                return null;
            }

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            
            var userIdClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub);
            if (userIdClaim != null && Guid.TryParse(userIdClaim.Value, out var userId))
            {
                return userId;
            }

            return null;
        }
        catch
        {
            return null;
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