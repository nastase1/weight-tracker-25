namespace WeightTracker.Shared.DTOs.Requests
{
    public class UpdateRecordRequest
    {
        public DateTime RecordDate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
    }
}