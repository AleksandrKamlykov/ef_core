using System.ComponentModel.DataAnnotations;

namespace Primera.Entities;

public class Match
{
    [Key]
    public Guid MatchId { get; set; }
    
    public int TeamHomeId { get; set; }
    public Team TeamHome { get; set; }

    public int TeamOnTourId { get; set; }
    public Team TeamOnTour { get; set; }

    public int TeamHomeScore { get; set; }
    public int TeamOnTourScore { get; set; }

    public ICollection<Goal> Goals { get; set; }
    
    [Required]
    public DateTime MatchDate { get; set; }

    
    
}