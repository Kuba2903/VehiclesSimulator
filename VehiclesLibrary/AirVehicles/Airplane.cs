using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    public sealed class Airplane : AirVehicles
    {

        public Airplane(string brand, FuelType fuel)
        {
            Brand = brand;
            Fuel = fuel.ToString();
            IsEngineVehicle = true;
        }

        public void FlyToTheAir()
        {
            if(Speed >= MinSpeed)
            {
                IsVehicleInAir = true;
                Console.WriteLine("The airplane soars to the air");
            }
        }

        public void LandToTheGround()
        {
            if(Speed == MinSpeed)
            {
                IsVehicleInAir = false;
                Console.WriteLine("The airplane is landing to the ground");
            }
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.airplane} / {EnvironmentEnum.Air} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the vehicle moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Is the vehicle in air: {IsVehicleInAir}";
    }
}
