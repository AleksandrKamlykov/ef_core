using Primera.Entities;

namespace Primera.Configurations;

public class Shared
{
    public static List<Team>    teams = new List<Team>
    {
        new Team { Id = 1, Name = "Real Madrid", City = "Madrid" },
        new Team { Id = 2, Name = "Barcelona", City = "Barcelona" },
        new Team { Id = 3, Name = "Atletico Madrid", City = "Madrid" },
        new Team { Id = 4, Name = "Valencia", City = "Valencia" },
        new Team { Id = 5, Name = "Sevilla", City = "Sevilla" },
        new Team { Id = 6, Name = "Real Sociedad", City = "San Sebastian" },
        new Team { Id = 7, Name = "Villarreal", City = "Villarreal" }
    };
                
 
}