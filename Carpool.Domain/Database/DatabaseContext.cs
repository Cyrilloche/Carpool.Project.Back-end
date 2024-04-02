using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("Server=localhost;User ID=root;Password=root;Database=carpool");
            optionsBuilder.UseMySQL("server=localhost;port=3308;database=carpool;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}