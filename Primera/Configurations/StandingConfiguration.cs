using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Primera.Entities;

namespace Primera.Configurations;

public class StandingConfiguration: IEntityTypeConfiguration<Standing>
{
    public void Configure(EntityTypeBuilder<Standing> builder)
    {
builder.HasOne(ts => ts.Team)
    .WithOne(t => t.Standings)
    .HasForeignKey<Standing>(ts => ts.TeamId);

         var standings = new List<Standing>();
        
         foreach (var team in Shared.teams)
         {
             standings.Add(new Standing
             {
                 TeamId = team.Id,
                 Wins = 0,
                 Losses = 0,
                 Draws = 0,
                 GoalsScored = 0,
                 GoalsConceded = 0
             });
         }


        builder.HasData(standings);
    }
}