using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Club_Portal.Models
{
    public class DbClass:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInformation>().ToTable("UserInformation", "dbo");
            modelBuilder.Entity<Pay>().ToTable("Payments", "dbo");
            modelBuilder.Entity<ClubInformation>().ToTable("ClubInformation", "dbo");
            modelBuilder.Entity<Permission>().ToTable("Permission", "dbo");

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserInformation> UserInformation { get; set; }
        public DbSet<Pay> Payments { get; set; }
       
        public DbSet<ClubInformation> ClubInformation { get; set; }
        public DbSet<Permission> Permission { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Filename=ClubManagement.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
