using Microsoft.AspNetCore.Mvc;
using WeightTracker.Infrastructure.Context;
using WeightTracker.Application.IServices;

namespace WeightTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthentificationController
    {
        private readonly WeightTrackerDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public AuthentificationController(WeightTrackerDbContext context, IConfiguration configuration, IUserService userService)
        {
            _context = context;
            _configuration = configuration;
            _userService = userService;
        }
    }
}