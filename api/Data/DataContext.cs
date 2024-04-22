using api.Domain;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).IsRequired();
                entity.Property(e => e.Firstname).IsRequired();
                entity.Property(e => e.Lastname).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.Age).IsRequired(false);
                entity.Property(e => e.Position).IsRequired().HasDefaultValue(Position.Developer);
            });
            modelBuilder.Entity<User>().HasData(
                new User { Id = Guid.NewGuid(), Firstname = "Vinnie", Lastname = "Cherry", Email = "hr.01@myCompany.com", Password = "@password01", Position = Position.Hr, Age = 25 },
                new User { Id = Guid.NewGuid(), Firstname = "Rose", Lastname = "Gonzales", Email = "hr.02@myCompany.com", Password = "@password02", Position = Position.Hr },
                new User { Id = Guid.NewGuid(), Firstname = "Montgomery", Lastname = "Garcia", Email = "hr.03@myCompany.com", Password = "@password03", Position = Position.Hr, Age = 45 },
                new User { Id = Guid.NewGuid(), Firstname = "Max", Lastname = "Rush", Email = "manager.01@myCompany.com", Password = "@password04", Position = Position.Manager, Age = 32 },
                new User { Id = Guid.NewGuid(), Firstname = "Zohaib", Lastname = "Wright", Email = "manager.02@myCompany.com", Password = "@password05", Position = Position.Manager, Age = 44 },
                new User { Id = Guid.NewGuid(), Firstname = "Harun", Lastname = "Clayton", Email = "developer.01@myCompany.com", Password = "@password06", Position = Position.Developer, Age = 27 },
                new User { Id = Guid.NewGuid(), Firstname = "Glenn", Lastname = "Carrillo", Email = "developer.02@myCompany.com", Password = "@password07", Position = Position.Developer, Age = 33 },
                new User { Id = Guid.NewGuid(), Firstname = "Rebekah", Lastname = "Matthams", Email = "developer.03@myCompany.com", Password = "@password08", Position = Position.Developer },
                new User { Id = Guid.NewGuid(), Firstname = "Simeon", Lastname = "Ferrell", Email = "developer.04@myCompany.com", Password = "@password09", Position = Position.Developer, Age = 51 },
                new User { Id = Guid.NewGuid(), Firstname = "Jordan", Lastname = "Mcpherson", Email = "developer.05@myCompany.com", Password = "@password10", Position = Position.Developer }
            );
        }
    }
}
