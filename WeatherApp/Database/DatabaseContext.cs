using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using WeatherApp.Database.Entity;

namespace WeatherApp.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jekon\source\repos\WeatherApp\WeatherApp\App_Data\Weather.mdf;Integrated Security=True");
        }
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<City> Cities { get; set; }
    }
}