using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Primera.Entities;

namespace Primera.Configurations;

public class ResultConfiguration: IEntityTypeConfiguration<Result>
{
    public void Configure(EntityTypeBuilder<Result> builder)
    {
       builder
           .HasOne(m => m.HomeTeam)
           .WithMany(t => t.HomeMatches)
           .HasForeignKey(m => m.HomeTeamId)
           .OnDelete(DeleteBehavior.NoAction);

        // Configure the relationship between Result and Team (OnTourTeam)
       builder
           .HasOne(m => m.AwayTeam)
           .WithMany(t => t.AwayMatches)
           .HasForeignKey(m => m.AwayTeamId)
           .OnDelete(DeleteBehavior.NoAction);
    }
}