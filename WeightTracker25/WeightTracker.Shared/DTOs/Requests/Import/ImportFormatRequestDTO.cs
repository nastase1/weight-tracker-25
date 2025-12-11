namespace WeightTracker.Shared.DTOs.Requests.Import
{
    public class ImportFormatRequestDTO
    {
        public List<SettingsFormatRequestDTO> Settings { get; set; } = new List<SettingsFormatRequestDTO>();
        public int Version { get; set; }
        public List<DataFormatRequestDTO> Weights { get; set; } = new List<DataFormatRequestDTO>();
    }
}