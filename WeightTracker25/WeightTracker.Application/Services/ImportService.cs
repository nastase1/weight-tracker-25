using WeightTracker.Application.IServices;
using WeightTracker.Shared.DTOs.Requests.Import;
using WeightTracker.Shared.DTOs.Responses.Import;
using WeightTracker.Shared.DTOs.Requests.Record;
using WeightTracker.Domain.Entities;

namespace WeightTracker.Application.Services
{
    public class ImportService : IImportService
    {
        private readonly IRecordService _recordService;

        public ImportService(IRecordService recordService)
        {
            _recordService = recordService;
        }

        public async Task<ImportFormatResponseDTO> ImportDataAsync(Guid userId, ImportFormatRequestDTO importRequest)
        {
            var importedCount = 0;
            var failedCount = 0;

            foreach (var dataEntry in importRequest.Weights)
            {
                try
                {
                    // Convert JavaScript timestamp (milliseconds) to DateTime
                    var recordDate = DateTimeOffset.FromUnixTimeMilliseconds(dataEntry.Date).DateTime;
                    
                    var recordDto = new CreateRecordRequestDTO
                    {
                        UserId = userId,
                        RecordDate = recordDate,
                        Weight = (decimal)dataEntry.Weight,
                        Height = 170m
                    };

                    var record = new Records
                    {
                        RecordId = Guid.NewGuid(),
                        UserId = recordDto.UserId,
                        RecordDate = recordDto.RecordDate,
                        Weight = recordDto.Weight,
                        Height = recordDto.Height,
                        CreatedAt = DateTime.UtcNow
                    };

                    await _recordService.AddAsync(record);
                    importedCount++;
                }
                catch (Exception)
                {
                    failedCount++;
                }
            }

            return new ImportFormatResponseDTO
            {
                Success = failedCount == 0,
                Message = $"Imported {importedCount} records successfully. {failedCount} failed.",
                ImportedRecords = importedCount,
                FailedRecords = failedCount
            };
        }
    }
}