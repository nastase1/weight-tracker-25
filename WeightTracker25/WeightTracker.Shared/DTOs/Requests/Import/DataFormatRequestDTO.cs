namespace WeightTracker.Shared.DTOs.Requests.Import
{
    public class DataFormatRequestDTO
    {
        public long Date { get; set; } // Unix timestamp in milliseconds
        public float Weight { get; set; }
    }
}