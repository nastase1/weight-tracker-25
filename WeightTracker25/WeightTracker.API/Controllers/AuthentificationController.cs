using Microsoft.AspNetCore.Mvc;
using WeightTracker.Infrastructure.Context;
using WeightTracker.Application.IServices;
using WeightTracker.Shared.DTOs.Requests.User;
using Microsoft.AspNetCore.Http.HttpResults;
using WeightTracker.Shared.DTOs.Responses.User;

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

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequestDTO request)
        {
            var user = new UserRegisterRequestDTO
            {
                Email = request.Email,
                Username = request.Username,
                Password = request.Password
            };
            var result = await _authentificationService.RegisterUserAsync(user);
            if (!result.Success)
            {
                return Ok(new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = result.Message
                });
            }
            return Ok(new UserRegisterResponseDTO
            {
                Success = true,
                Message = "User registered successfully."
            });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequestDTO request)
        {
            var user = new UserLoginRequestDTO
            {
                Username = request.Username,
                Password = request.Password
            };
            var result = await _authentificationService.LoginUserAsync(user);
            if (!result.Success)
            {
                return Ok(new UserLoginResponseDTO
                {
                    Success = false,
                    Token = null,
                    Message = result.Message
                });
            }
            // Here you would normally generate a JWT token or similar
            string token = "dummy-jwt-token"; // Replace with actual token generation logic

            return Ok(new UserLoginResponseDTO
            {
                Success = true,
                Token = token,
                Message = "User logged in successfully."
            });
        }
    }
}