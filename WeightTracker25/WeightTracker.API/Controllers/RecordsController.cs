using Microsoft.AspNetCore.Mvc;
using WeightTracker.Application.IServices;
using WeightTracker.Shared.DTOs.Requests.Record;
using WeightTracker.Shared.DTOs.Responses.Record;
using WeightTracker.Domain.Entities;

namespace WeightTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecordsController : ControllerBase
    {
        private readonly IRecordService _recordService;
        private readonly IUserService _userService;

        public RecordsController(IRecordService recordService, IUserService userService)
        {
            _recordService = recordService;
            _userService = userService;
        }

        /// <summary>
        /// Get all records
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Records>>> GetAllRecords()
        {
            var records = await _recordService.GetAllAsync();
            return Ok(records);
        }

        /// <summary>
        /// Get record by ID
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Records>> GetRecordById(Guid id)
        {
            var record = await _recordService.GetByIdAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Record with ID {id} not found" });
            }
            return Ok(record);
        }

        /// <summary>
        /// Get all records for a specific user
        /// </summary>
        [HttpGet("user/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Records>>> GetRecordsByUserId(Guid userId)
        {
            var userExists = await _userService.ExistsAsync(userId);
            if (!userExists)
            {
                return NotFound(new { message = $"User with ID {userId} not found" });
            }

            var records = await _recordService.GetByUserIdAsync(userId);
            return Ok(records);
        }

        /// <summary>
        /// Get record for a user on a specific date
        /// </summary>
        [HttpGet("user/{userId}/date/{date}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Records>> GetRecordByUserIdAndDate(Guid userId, DateTime date)
        {
            var record = await _recordService.GetByUserIdAndDateAsync(userId, date);
            if (record == null)
            {
                return NotFound(new { message = $"No record found for user {userId} on date {date:yyyy-MM-dd}" });
            }
            return Ok(record);
        }

        /// <summary>
        /// Get records for a user within a date range
        /// </summary>
        [HttpGet("user/{userId}/range")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Records>>> GetRecordsByDateRange(
            Guid userId,
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate)
        {
            if (startDate > endDate)
            {
                return BadRequest(new { message = "Start date must be before or equal to end date" });
            }

            var userExists = await _userService.ExistsAsync(userId);
            if (!userExists)
            {
                return NotFound(new { message = $"User with ID {userId} not found" });
            }

            var records = await _recordService.GetByUserIdAndDateRangeAsync(userId, startDate, endDate);
            return Ok(records);
        }

        /// <summary>
        /// Get interpolated data for a user within a date range
        /// </summary>
        [HttpGet("user/{userId}/interpolated")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<InterpolatedRecordResponseDTO>>> GetInterpolatedRecords(
            Guid userId,
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate)
        {
            if (startDate > endDate)
            {
                return BadRequest(new { message = "Start date must be before or equal to end date" });
            }

            var userExists = await _userService.ExistsAsync(userId);
            if (!userExists)
            {
                return NotFound(new { message = $"User with ID {userId} not found" });
            }

            var records = await _recordService.GetByUserIdAndDateRangeAsync(userId, startDate, endDate);
            var interpolatedData = InterpolateData(records.ToList(), startDate, endDate);

            return Ok(interpolatedData);
        }

        /// <summary>
        /// Get smoothed data (moving average) for a user within a date range
        /// </summary>
        [HttpGet("user/{userId}/smoothed")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<SmoothedRecordResponseDTO>>> GetSmoothedRecords(
            Guid userId,
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate,
            [FromQuery] int windowDays = 7)
        {
            if (startDate > endDate)
            {
                return BadRequest(new { message = "Start date must be before or equal to end date" });
            }

            if (windowDays < 1)
            {
                return BadRequest(new { message = "Window days must be at least 1" });
            }

            var userExists = await _userService.ExistsAsync(userId);
            if (!userExists)
            {
                return NotFound(new { message = $"User with ID {userId} not found" });
            }

            var records = await _recordService.GetByUserIdAndDateRangeAsync(userId, startDate, endDate);
            var smoothedData = SmoothData(records.ToList(), windowDays);

            return Ok(smoothedData);
        }

        /// <summary>
        /// Create a new record
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Records>> CreateRecord([FromBody] CreateRecordRequestDTO request)
        {
            // Validate user exists
            var userExists = await _userService.ExistsAsync(request.UserId);
            if (!userExists)
            {
                return NotFound(new { message = $"User with ID {request.UserId} not found" });
            }

            // Check if record already exists for this user and date
            var existingRecord = await _recordService.GetByUserIdAndDateAsync(request.UserId, request.RecordDate);
            if (existingRecord != null)
            {
                return BadRequest(new { message = $"A record already exists for user {request.UserId} on date {request.RecordDate:yyyy-MM-dd}" });
            }

            var record = new Records
            {
                UserId = request.UserId,
                RecordDate = request.RecordDate,
                Weight = request.Weight,
                Height = request.Height
            };

            var createdRecord = await _recordService.AddAsync(record);
            return CreatedAtAction(nameof(GetRecordById), new { id = createdRecord.RecordId }, createdRecord);
        }

        /// <summary>
        /// Update an existing record
        /// </summary>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Records>> UpdateRecord(Guid id, [FromBody] UpdateRecordRequestDTO request)
        {
            var existingRecord = await _recordService.GetByIdAsync(id);
            if (existingRecord == null)
            {
                return NotFound(new { message = $"Record with ID {id} not found" });
            }

            existingRecord.Weight = request.Weight;
            existingRecord.Height = request.Height;
            existingRecord.RecordDate = request.RecordDate;

            var updatedRecord = await _recordService.UpdateAsync(existingRecord);
            return Ok(updatedRecord);
        }

        /// <summary>
        /// Delete a record (soft delete)
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteRecord(Guid id)
        {
            var result = await _recordService.DeleteAsync(id);
            if (!result)
            {
                return NotFound(new { message = $"Record with ID {id} not found" });
            }
            return Ok(new { message = "Record deleted successfully" });
        }

        // Helper methods for interpolation and smoothing
        private List<InterpolatedRecordResponseDTO> InterpolateData(List<Records> records, DateTime startDate, DateTime endDate)
        {
            var result = new List<InterpolatedRecordResponseDTO>();

            if (!records.Any())
            {
                return result;
            }

            var orderedRecords = records.OrderBy(r => r.RecordDate).ToList();

            for (var date = startDate.Date; date <= endDate.Date; date = date.AddDays(1))
            {
                var exactRecord = orderedRecords.FirstOrDefault(r => r.RecordDate.Date == date);

                if (exactRecord != null)
                {
                    result.Add(new InterpolatedRecordResponseDTO
                    {
                        Date = date,
                        Weight = exactRecord.Weight,
                        Height = exactRecord.Height,
                        IsInterpolated = false
                    });
                }
                else
                {
                    // Find records before and after this date
                    var before = orderedRecords.LastOrDefault(r => r.RecordDate.Date < date);
                    var after = orderedRecords.FirstOrDefault(r => r.RecordDate.Date > date);

                    if (before != null && after != null)
                    {
                        // Linear interpolation
                        var totalDays = (after.RecordDate.Date - before.RecordDate.Date).TotalDays;
                        var daysFromBefore = (date - before.RecordDate.Date).TotalDays;
                        var ratio = daysFromBefore / totalDays;

                        var interpolatedWeight = before.Weight + (after.Weight - before.Weight) * (decimal)ratio;
                        var interpolatedHeight = before.Height + (after.Height - before.Height) * (decimal)ratio;

                        result.Add(new InterpolatedRecordResponseDTO
                        {
                            Date = date,
                            Weight = Math.Round(interpolatedWeight, 2),
                            Height = Math.Round(interpolatedHeight, 2),
                            IsInterpolated = true
                        });
                    }
                    else if (before != null)
                    {
                        // Use last known value
                        result.Add(new InterpolatedRecordResponseDTO
                        {
                            Date = date,
                            Weight = before.Weight,
                            Height = before.Height,
                            IsInterpolated = true
                        });
                    }
                    else if (after != null)
                    {
                        // Use next known value
                        result.Add(new InterpolatedRecordResponseDTO
                        {
                            Date = date,
                            Weight = after.Weight,
                            Height = after.Height,
                            IsInterpolated = true
                        });
                    }
                }
            }

            return result;
        }

        private List<SmoothedRecordResponseDTO> SmoothData(List<Records> records, int windowDays)
        {
            var result = new List<SmoothedRecordResponseDTO>();

            if (!records.Any())
            {
                return result;
            }

            var orderedRecords = records.OrderBy(r => r.RecordDate).ToList();

            foreach (var record in orderedRecords)
            {
                var windowStart = record.RecordDate.AddDays(-windowDays / 2);
                var windowEnd = record.RecordDate.AddDays(windowDays / 2);

                var windowRecords = orderedRecords
                    .Where(r => r.RecordDate >= windowStart && r.RecordDate <= windowEnd)
                    .ToList();

                if (windowRecords.Any())
                {
                    var avgWeight = windowRecords.Average(r => r.Weight);
                    var avgHeight = windowRecords.Average(r => r.Height);

                    result.Add(new SmoothedRecordResponseDTO
                    {
                        Date = record.RecordDate,
                        OriginalWeight = record.Weight,
                        SmoothedWeight = Math.Round(avgWeight, 2),
                        OriginalHeight = record.Height,
                        SmoothedHeight = Math.Round(avgHeight, 2),
                        WindowSize = windowRecords.Count
                    });
                }
            }

            return result;
        }
    }
}