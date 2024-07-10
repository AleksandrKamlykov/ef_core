using Microsoft.EntityFrameworkCore;
using Primera.Entities;

namespace Primera.Context;

public  class PrimeraContext : DbContext
{
    
    private string connectionString = "Server=localhost,1433;Database=Primera;User=SA;Password=kamlykov;TrustServerCertificate=true;";

    public PrimeraContext()
    {
         // Database.EnsureDeleted();
         // Database.EnsureCreated();
    }
    public PrimeraContext(DbContextOptions<PrimeraContext> options):base(options)
    {
                
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
                
        modelBuilder.Entity<Team>().HasData(
            new Team { Id = 1, Name = "Real Madrid", City = "Madrid", Wins = 0, Lose = 0, Draw = 0 },
            new Team { Id = 2, Name = "Barcelona", City = "Barcelona", Wins = 0, Lose = 0, Draw = 0 },
            new Team { Id = 3, Name = "Atletico Madrid", City = "Madrid", Wins = 0, Lose = 0, Draw = 0 },
            new Team { Id = 4, Name = "Valencia", City = "Valencia", Wins = 0, Lose = 0, Draw = 0 },
            new Team { Id = 5, Name = "Sevilla", City = "Sevilla", Wins = 0, Lose = 0, Draw = 0 },
            new Team { Id = 6, Name = "Real Sociedad", City = "San Sebastian", Wins = 0, Lose = 0, Draw = 0 },
            new Team { Id = 7, Name = "Villarreal", City = "Villarreal", Wins = 0, Lose = 0, Draw = 0 });
                
        base.OnModelCreating(modelBuilder);
    }


    public virtual DbSet<Team>Teams { get; set; }
        
}