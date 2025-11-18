using Microsoft.AspNetCore.Mvc;
using WeightTracker.Application.IServices;
using WeightTracker.Infrastructure.Context;

namespace WeightTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController
    {
        private readonly WeightTrackerDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public UserController(WeightTrackerDbContext context, IConfiguration configuration, IUserService userService)
        {
            _context = context;
            _configuration = configuration;
            _userService = userService;
        }
    }
}