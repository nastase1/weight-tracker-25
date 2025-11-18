namespace WeightTracker.Shared.DTOs.Responses
{
    public class SmoothedRecordResponse
    {
        public DateTime Date { get; set; }
        public decimal OriginalWeight { get; set; }
        public decimal SmoothedWeight { get; set; }
        public decimal OriginalHeight { get; set; }
        public decimal SmoothedHeight { get; set; }
        public int WindowSize { get; set; }
    }
}