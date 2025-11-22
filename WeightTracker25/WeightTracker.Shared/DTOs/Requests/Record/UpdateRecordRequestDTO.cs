namespace WeightTracker.Shared.DTOs.Requests.Record
{
    public class UpdateRecordRequestDTO
    {
        public DateTime RecordDate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
    }
}