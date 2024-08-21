using System.ComponentModel.DataAnnotations;

namespace Primera.Entities;

public class Player
{
    [Key]
    public int PlayerId { get; set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    public string Country { get; set; }

    [Required]
    public int PlayerNumber { get; set; }

    [Required]
    public string Position { get; set; }
    
    public int TeamId { get; set; }
    public Team Team { get; set; }
}
