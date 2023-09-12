using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary.LandVehicles
{
    [Serializable]
    [DataContract (IsReference = true)]
    public sealed class Car : LandVehicle
    {

        //Speed is counted in Km/h
        public override int MaxSpeed { get; protected set; } = 350;
        public Car(string brand,FuelType fuel)
        {
            IsEngineVehicle = true;
            WheelNum = 4;
            Brand = brand;
            Fuel = fuel.ToString();
        }

        /// <summary>
        /// Starting the car
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
        /// Turning the car off
        /// </summary>
        public void TurnOff()
        {
            if(IsStarted)
            {
                IsStarted = false;
                IsMoving = false;
                Speed = 0;
                Console.WriteLine("Vehicle is off");
            }
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.car} / {EnvironmentEnum.Land} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the car moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Number of wheels: {WheelNum}";
    }
}
