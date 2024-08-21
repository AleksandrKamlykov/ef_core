using System.ComponentModel.DataAnnotations;
using Primera.Entities;

public class Team
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(100)]
    public string City { get; set; }
    
    // Навігаційні властивості
    public virtual ICollection<Result> HomeMatches { get; set; } = [];
    public virtual ICollection<Result> AwayMatches { get; set; } = [];
    public virtual Standing Standings { get; set; }
    
    public override string ToString()
    {
        return $"Team: {Name}; City: {City};";
    }
}