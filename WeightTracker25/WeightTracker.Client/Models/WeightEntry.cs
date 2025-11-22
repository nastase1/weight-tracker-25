using System.ComponentModel.DataAnnotations;

namespace WeightTracker.Client.Models;

public class WeightEntry
{
    public int Id { get; set; }
    
    [Required]
    public DateTime Date { get; set; }
    
    [Required(ErrorMessage = "Weight is required")]
    [Range(1, 1000, ErrorMessage = "Weight must be between 1 and 1000 kg")]
    public decimal Weight { get; set; }
    
    [MaxLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
    public string? Notes { get; set; }
    
    public Guid UserId { get; set; } = Guid.Empty;
}

public class WeightStats
{
    public decimal CurrentWeight { get; set; }
    public decimal? PreviousWeight { get; set; }
    public decimal? WeightChange => PreviousWeight.HasValue ? CurrentWeight - PreviousWeight.Value : null;
    public decimal? StartingWeight { get; set; }
    public decimal? TotalChange => StartingWeight.HasValue ? CurrentWeight - StartingWeight.Value : null;
    public int TotalEntries { get; set; }
    public DateTime? LastEntry { get; set; }
}

public class ChartDataPoint
{
    public DateTime Date { get; set; }
    public decimal Weight { get; set; }
}