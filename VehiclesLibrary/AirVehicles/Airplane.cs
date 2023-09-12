using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    [Serializable]
    [DataContract(IsReference = true)]
    public sealed class Airplane : AirVehicles
    {
        private string Environment { get; set; }

        //airplane is slower in land environment than in air environment
        public override int MaxSpeed
        {
            get
            {
                if (Environment == EnvironmentEnum.Land.ToString())
                    return 50;
                else return 200;
            }
        }
        public Airplane(string brand, FuelType fuel)
        {
            Brand = brand;
            Fuel = fuel.ToString();
            IsEngineVehicle = true;
            Environment = EnvironmentEnum.Land.ToString();
        }

        /// <summary>
        /// The airplane flies to the air from the ground, when the speed is more than 20 m/s
        /// </summary>
        public void FlyToTheAir()
        {
            if(Speed >= MinSpeed)
            {
                IsVehicleInAir = true;
                this.Environment = EnvironmentEnum.Air.ToString();
                Console.WriteLine("The airplane soars to the air");
            }
        }

        /// <summary>
        /// The airplane lands to the ground when the speed is exactly 20 m/s
        /// </summary>
        public void LandToTheGround()
        {
            if(Speed == MinSpeed)
            {
                IsVehicleInAir = false;
                this.Environment = EnvironmentEnum.Land.ToString();
                Console.WriteLine("The airplane is landing to the ground");
            }
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.airplane} / {Environment} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the vehicle moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Is the vehicle in air: {IsVehicleInAir}";
    }
}
