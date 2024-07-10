namespace Primera.Entities;

public class Team
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public int Wins { get; set; }
    public int Lose { get; set; }
    public int Draw { get; set; }
    public int Scored { get; set; }
    public int Conceded { get; set; }


    public override string ToString()
    {
        return $"Team: {Name}; City: {City}; Wins - {Wins}; Lose - {Lose}; Draw - {Draw}";
    }
}