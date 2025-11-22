namespace WeightTracker.Shared.DTOs.Responses.Record
{
    public class SmoothedRecordResponseDTO
    {
        public DateTime Date { get; set; }
        public decimal OriginalWeight { get; set; }
        public decimal SmoothedWeight { get; set; }
        public decimal OriginalHeight { get; set; }
        public decimal SmoothedHeight { get; set; }
        public int WindowSize { get; set; }
    }
}