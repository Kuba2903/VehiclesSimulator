using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary.Models
{
    public class AirVehiclesModel
    {
        [Key]
        public int Id { get; set; }

        public string VehicleType { get; set; } = null!;

        public string? Brand { get; set; }

        public string? FuelType { get; set; }

        public short MaxSpeed { get; set; }
    }
}
