using Microsoft.EntityFrameworkCore;

namespace Club_Portal.Models
{
    public class SqlServerDbClass:DbContext
    {
        public SqlServerDbClass(DbContextOptions<SqlServerDbClass> options):
            base(options) { }
        public DbSet<Events> Events { get; set; }
        public DbSet<EventSubscription> Subscriptions { get; set; }
        public DbSet<UserInformation> UserInformation { get; set; }
        public DbSet<Pay> Payments { get; set; }
        public DbSet<ClubInformation> ClubInformation { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventSubscription>()
     .HasKey(t =>new
     {
         t.ID,
         t.ClubID,
         t.UserID
     }
            );
        }
    }
}
