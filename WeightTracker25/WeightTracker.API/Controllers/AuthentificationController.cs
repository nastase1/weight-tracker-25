using Microsoft.AspNetCore.Mvc;
using WeightTracker.Infrastructure.Context;
using WeightTracker.Application.IServices;
using WeightTracker.Shared.DTOs.Requests.User;
using Microsoft.AspNetCore.Http.HttpResults;
using WeightTracker.Shared.DTOs.Responses.User;
using Microsoft.AspNetCore.Authorization;

namespace WeightTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthentificationController : ControllerBase
    {
        private readonly WeightTrackerDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly IAuthentificationService _authentificationService;

        public AuthentificationController(WeightTrackerDbContext context, IConfiguration configuration, IUserService userService, IAuthentificationService authentificationService)
        {
            _context = context;
            _configuration = configuration;
            _userService = userService;
            _authentificationService = authentificationService;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequestDTO request)
        {
            var result = await _authentificationService.RegisterUserAsync(request);

            if (!result.Success)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequestDTO request)
        {
            var result = await _authentificationService.LoginUserAsync(request);

            if (!result.Success)
            {
                return Unauthorized(result);
            }

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequestDTO request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage) });
            }

            var result = await _authentificationService.ForgotPasswordAsync(request);

            if (!result.Success)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequestDTO request)
        {
            var result = await _authentificationService.ResetPasswordAsync(request);

            if (!result.Success)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
