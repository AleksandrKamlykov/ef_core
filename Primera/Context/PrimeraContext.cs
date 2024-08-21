using Microsoft.EntityFrameworkCore;
using Primera.Configurations;
using Primera.Entities;

namespace Primera.Context;

public  class PrimeraContext : DbContext
{
    
    private string connectionString = "Server=localhost,1433;Database=Primera;User=SA;Password=kamlykov;TrustServerCertificate=true;";

    public PrimeraContext()
    {
         Database.EnsureDeleted();
         Database.EnsureCreated();
    }
    public PrimeraContext(DbContextOptions<PrimeraContext> options):base(options)
    {
                
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TeamConfiguration());

        modelBuilder.ApplyConfiguration(new StandingConfiguration());
                
        base.OnModelCreating(modelBuilder);
    }


    public virtual DbSet<Team>Teams { get; set; }
    public virtual DbSet<Result>Results { get; set; }
    public virtual DbSet<Standing>Standings { get; set; }
        
}