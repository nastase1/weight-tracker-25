using Microsoft.AspNetCore.Mvc;
using WeightTracker.Application.IServices;
using WeightTracker.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace WeightTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("users")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Users>>> GetAllUsers()
        {
            var users = await _adminService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("users/{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Users>> GetUserById(Guid id)
        {
            var user = await _adminService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound(new { message = $"User with ID {id} not found" });
            }
            return Ok(user);
        }

        [HttpPost("users/{id}/deactivate")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeactivateUser(Guid id)
        {
            var result = await _adminService.DeactivateUserAsync(id);
            if (!result)
            {
                return NotFound(new { message = $"User with ID {id} not found" });
            }
            return Ok(new { message = "User deactivated successfully" });
        }

        [HttpPost("users/{id}/activate")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ActivateUser(Guid id)
        {
            var result = await _adminService.ActivateUserAsync(id);
            if (!result)
            {
                return NotFound(new { message = $"User with ID {id} not found" });
            }
            return Ok(new { message = "User activated successfully" });
        }
    }
}

