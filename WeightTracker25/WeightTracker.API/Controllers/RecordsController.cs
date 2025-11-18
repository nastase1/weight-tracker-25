using Microsoft.AspNetCore.Mvc;
using WeightTracker.Application.IServices;
using WeightTracker.Infrastructure.Context;

namespace WeightTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecordsController
    {
        private readonly WeightTrackerDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IRecordService _recordService;
        public RecordsController(WeightTrackerDbContext context, IConfiguration configuration, IRecordService recordService)
        {
            _context = context;
            _configuration = configuration;
            _recordService = recordService;
        }
    }
}