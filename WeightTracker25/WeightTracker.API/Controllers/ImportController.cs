using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WeightTracker.Application.IServices;
using WeightTracker.Shared.DTOs.Requests.Import;

namespace WeightTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ImportController : ControllerBase
    {
        private readonly IImportService _importService;

        public ImportController(IImportService importService)
        {
            _importService = importService;
        }

        [HttpPost("json")]
        public async Task<IActionResult> ImportJsonData([FromBody] ImportFormatRequestDTO importRequest)
        {
            // Extract UserId from JWT token for security
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? User.FindFirst("sub")?.Value;
            if (!Guid.TryParse(userIdClaim, out var userId))
            {
                return Unauthorized("Invalid user token");
            }

            if (importRequest == null)
            {
                return BadRequest("Invalid import data.");
            }

            var result = await _importService.ImportDataAsync(userId, importRequest);
            return Ok(result);
        }
    }
}