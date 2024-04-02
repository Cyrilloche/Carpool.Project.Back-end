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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}