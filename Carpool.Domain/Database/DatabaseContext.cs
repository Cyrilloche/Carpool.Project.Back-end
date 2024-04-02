using Microsoft.EntityFrameworkCore;

namespace Carpool.Domain.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("Server=localhost;User ID=root;Password=root;Database=carpool");
            string connectionString = "server=localhost;port=3308;database=carpool;user=root;password=;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}