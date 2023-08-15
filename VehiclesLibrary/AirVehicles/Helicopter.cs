using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary { 
    public class Helicopter : AirVehicles
    {

        public Helicopter(string brand, FuelType fuel)
        {
            Brand = brand;
            Fuel = fuel.ToString();
            IsEngineVehicle = true;
        }

        public void FlyToTheAir()
        {
            IsVehicleInAir = true;
            Console.WriteLine("The helicopter soars to the air");
        }

        public void LandToTheGround()
        {
            if (Speed == MinSpeed)
            {
                IsVehicleInAir = false;
                Console.WriteLine("The helicopter is landing to the ground");
            }
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.helicopter} / {EnvironmentEnum.Air} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the vehicle moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Is the vehicle in air: {IsVehicleInAir}";
    }
}
