namespace WeightTracker.Shared.DTOs.Responses.Record
{
    public class InterpolatedRecordResponseDTO
    {
        public DateTime Date { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public bool IsInterpolated { get; set; }
    }
}