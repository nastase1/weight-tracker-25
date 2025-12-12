namespace WeightTracker.Shared.DTOs.Requests.Import
{
    public class ImportFormatRequestDTO
    {
        public List<DataFormatRequestDTO> Weights { get; set; } = new List<DataFormatRequestDTO>();
    }
}