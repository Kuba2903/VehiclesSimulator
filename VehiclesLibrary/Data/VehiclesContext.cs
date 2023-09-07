using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLibrary.Models;

namespace VehiclesLibrary.Data
{
    public class VehiclesContext : DbContext
    {
        public DbSet<AirVehiclesModel> AirVehicles { get; set;}
        public DbSet<LandVehiclesModel> LandVehicles { get; set;}
        public DbSet<WaterVehiclesModel> WaterVehicles { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UCCK6JP;Initial Catalog=VehiclesDatabase;Integrated Security=True; TrustServerCertificate=True");
        }
    }
}
