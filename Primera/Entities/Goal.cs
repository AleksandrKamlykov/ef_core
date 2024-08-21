using System.ComponentModel.DataAnnotations;

namespace Primera.Entities;

public class Goal
{
    [Key]
    public int GoalId { get; set; }

    public int PlayerId { get; set; }
    public Player Player { get; set; }

    public int MatchId { get; set; }
    public Match Match { get; set; }

}