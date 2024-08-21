using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primera.Entities;


public class Result
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public int HomeTeamId { get; set; }
    
    [Required]
    public int AwayTeamId { get; set; }
    
    [Required]
    public int HomeTeamGoals { get; set; }
    
    [Required]
    public int AwayTeamGoals { get; set; }
    
    // Навігаційні властивості
    [ForeignKey("HomeTeamId")]
    public virtual Team HomeTeam { get; set; }
    
    [ForeignKey("AwayTeamId")]
    public virtual Team AwayTeam { get; set; }
}