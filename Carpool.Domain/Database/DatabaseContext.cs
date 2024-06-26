using System.Reflection;
using Carpool.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpool.Domain.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3308;database=carpool;user=root;password=;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<UserTravelPreference> UserTravelPreferences { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<DriverType> DriverTypes { get; set; }
        public DbSet<UserReward> UserRewards { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<UserReservation> UserReservations { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<TravelFilter> TravelFilters { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<TravelStage> TravelStages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}