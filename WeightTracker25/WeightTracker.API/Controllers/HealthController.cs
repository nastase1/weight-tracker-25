using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace WeightTracker.API.Controllers
{
    /// <summary>
    /// Health check endpoint for monitoring
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Basic health check endpoint
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version?.ToString() ?? "1.0.0.0";

            return Ok(new
            {
                status = "healthy",
                timestamp = DateTime.UtcNow,
                service = "WeightTracker.API",
                version
            });
        }
    }
}
