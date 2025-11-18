namespace WeightTracker.Shared.DTOs.Responses
{
    public class InterpolatedRecordResponse
    {
        public DateTime Date { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public bool IsInterpolated { get; set; }
    }
}