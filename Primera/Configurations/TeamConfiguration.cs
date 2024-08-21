using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Primera.Entities;

namespace Primera.Configurations;

public class TeamConfiguration: IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder
            .HasOne(t => t.Standings);
            //.WithOne(s => s.Team);

            // foreach (var team in Shared.teams)
            // {
            //     team.Standing = new Standing()
            //     {
            //         Id = team.Id,
            //         Wins = 0,
            //         Lose = 0,
            //         Draw = 0,
            //         Scored = 0,
            //         Conceded = 0
            //     };
            // }
            
        builder.HasData(
            Shared.teams
            );
    }
}