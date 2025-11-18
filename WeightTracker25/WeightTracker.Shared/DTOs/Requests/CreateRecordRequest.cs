namespace WeightTracker.Shared.DTOs.Requests
{
    public class CreateRecordRequest
    {
        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
    }
}