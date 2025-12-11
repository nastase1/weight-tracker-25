using WeightTracker.Shared.DTOs.Requests.Import;
using WeightTracker.Shared.DTOs.Responses.Import;

namespace WeightTracker.Application.IServices
{
    public interface IImportService
    {
        Task<ImportFormatResponseDTO> ImportDataAsync(Guid userId, ImportFormatRequestDTO importRequest);
    }
}