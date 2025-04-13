using Microsoft.EntityFrameworkCore;
using AirportManagementSystem.Models;

namespace AirportManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // الاتصال بقاعدة بيانات SQLite
            options.UseSqlite("Data Source=airportManagement.db");
        }
    }
}
