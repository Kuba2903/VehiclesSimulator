using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary.LandVehicles
{
    [Serializable]
    [DataContract(IsReference = true)]
    public sealed class ElectricBoard : LandVehicle
    {
        public override int MaxSpeed { get; protected set; } = 40;

        public ElectricBoard(string brand)
        {
            IsEngineVehicle = true;
            WheelNum = 2;
            Brand = brand;
            Fuel = FuelType.Electric.ToString();
        }

        /// <summary>
        /// Starting the board
        /// </summary>
        public void StartOn()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                Console.WriteLine("Vehicle started");
            }
        }

        /// <summary>
        /// Turning off
        /// </summary>
        public void TurnOff()
        {
            if (IsStarted)
            {
                IsStarted = false;
                IsMoving = false;
                Speed = 0;
                Console.WriteLine("Vehicle is off");
            }
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.electricBoard} / {EnvironmentEnum.Land} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the car moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Number of wheels: {WheelNum}";
    }
}
