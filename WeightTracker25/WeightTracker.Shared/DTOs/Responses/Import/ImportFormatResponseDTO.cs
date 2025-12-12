namespace WeightTracker.Shared.DTOs.Responses.Import
{
    public class ImportFormatResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public int ImportedRecords { get; set; }
        public int FailedRecords { get; set; } = 0;
        public int AddedRecords { get; set; } = 0;
        public int UpdatedRecords { get; set; } = 0;
    }
}