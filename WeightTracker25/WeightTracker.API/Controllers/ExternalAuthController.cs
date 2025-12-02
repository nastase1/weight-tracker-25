using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WeightTracker.Application.IServices;

namespace WeightTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExternalAuthController : ControllerBase
    {
        private readonly IAuthentificationService _authService;
        private readonly IConfiguration _configuration;

        public ExternalAuthController(IAuthentificationService authService, IConfiguration configuration)
        {
            _authService = authService;
            _configuration = configuration;
        }

        [HttpGet("google-login")]
        public IActionResult GoogleLogin()
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleCallback")
            };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        [HttpGet("google-callback")]
        public async Task<IActionResult> GoogleCallback()
        {
            var authenticateResult = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

            if (!authenticateResult.Succeeded)
            {
                return Redirect($"{_configuration["BlazorClientUrl"]}/login?error=google_auth_failed");
            }

            var claims = authenticateResult.Principal.Claims;
            var email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var name = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            var googleId = claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(email))
            {
                return Redirect($"{_configuration["BlazorClientUrl"]}/login?error=no_email");
            }

            var token = await _authService.AuthenticateWithGoogleAsync(email, name, googleId);

            return Redirect($"{_configuration["BlazorClientUrl"]}/login-success?token={token}");
        }
    }
}