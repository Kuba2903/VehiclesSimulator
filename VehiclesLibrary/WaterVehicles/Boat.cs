using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehiclesLibrary.VehiclesAbstract;

namespace VehiclesLibrary.WaterVehicles
{
    public class Boat : WaterVehicle
    {
        public Boat(string brand, int displacement)
        {
            IsEngineVehicle = false;
            Fuel = null;
            Brand = brand;
            Displacement = displacement;
            IsStarted = true;
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.boat} / {EnvironmentEnum.Water} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the vehicle moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Displacement: {Displacement}";
    }
}
