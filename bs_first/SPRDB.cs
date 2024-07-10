using bs_first.Entities;
using Microsoft.EntityFrameworkCore;
namespace bs_first;

//
//
// public partial class SPRDBContext : DbContext
// {
//     public SPRDBContext()
//     {
//         //Database.EnsureDeleted();
//         //Database.EnsureCreated();
//     }
//     private string connectionString = "Server=localhost,1433;Database=SPR;User=SA;Password=kamlykov;TrustServerCertificate=true;";
//
//
//     public SPRDBContext(DbContextOptions<SPRDBContext> options)
//         : base(options)
//     {
//     }
//     
//     public virtual DbSet<Student> Students { get; set; }
//
//     //public virtual DbSet<Group> Groups { get; set; }
//
//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         => optionsBuilder.UseSqlServer(connectionString);
//
//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder.Entity<Student>(entity =>
//         {
//            // entity.Property(e => e.Name).HasMaxLength(50);
//             //entity.Property(e => e.LastName).HasMaxLength(50);
//         });
//
//         //modelBuilder.Ignore<Address>();
//
//         //modelBuilder.Ignore<Group>();
//
//        // modelBuilder.Entity<Student>().Ignore(s => s.PersonalInfo);
//
//         //modelBuilder.Entity<Student>().ToTable("Users");
//
//         //modelBuilder.Entity<Student>()
//         //    .HasKey(s => new {s.Name, s.LastName})
//         //    .HasName("MyName");
//
//         //modelBuilder.Entity<Student>().HasAlternateKey(s => s.PersonalInfo);
//
//         // modelBuilder.Entity<Student>()
//         //     .Property(s => s.BirthDay)
//         //     .HasDefaultValue(new DateOnly(2000, 1, 1));
//         //
//         // modelBuilder.Entity<Student>()
//         //     .Property(s => s.CreatedAt)
//         //     .HasDefaultValueSql("GETDATE()");
//
//         modelBuilder.Entity<Student>().HasData(
//             new Student
//             {
//                 Id = 1,
//                 Name = "John",
//               //  LastName = "Doe",
//                 BirthDay = new DateOnly(2000, 1, 1)
//             },
//             new Student
//             {
//                 Id = 2,
//                 Name = "Jane",
//                // LastName = "Doe",
//                 BirthDay = new DateOnly(1999, 1, 1)
//             }
//         );
//
//         OnModelCreatingPartial(modelBuilder);
//     }
//
//     partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
// }