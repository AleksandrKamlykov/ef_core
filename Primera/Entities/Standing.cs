using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primera.Entities
{
    public class Standing
    {
        [Key]
        public int Id { get; set; }
    
        [Required]
        public int TeamId { get; set; }
    
        public int GoalsScored { get; set; }
    
        public int GoalsConceded { get; set; }
    
        public int Wins { get; set; }
    
        public int Losses { get; set; }
    
        public int Draws { get; set; }
    
        // Навігаційна властивість
        [ForeignKey("TeamId")]
        public virtual Team? Team { get; set; }

        public override string ToString()
        {
            return $"Wins - {Wins}; Lose - {Losses}; Draw - {Draws}";
        }
    }
}
