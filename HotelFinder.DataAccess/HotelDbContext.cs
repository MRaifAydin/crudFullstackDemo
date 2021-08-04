using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
            IConfigurationRoot configuration = configBuilder.Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Garage> Garages { get; set; }
    }
}
