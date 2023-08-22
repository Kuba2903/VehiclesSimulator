using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary.LandVehicles
{
    public sealed class MotorBike : LandVehicle
    {
        //Speed is counted in Km/h
        private int MaxSpeed { get; } = 350;

        public MotorBike(string brand, FuelType fuel)
        {
            IsEngineVehicle = true;
            WheelNum = 2;
            Brand = brand;
            Fuel = fuel.ToString();
        }
        public void StartOn()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                Console.WriteLine("Vehicle started");
            }
        }

        public void TurnOff()
        {
            if (IsStarted)
            {
                IsStarted = false;
                Console.WriteLine("Vehicle is off");
            }
        }

        public override void Accelerate(int speed)
        {
            if (IsStarted && speed > 0)
            {
                int tempSpeed = Speed += speed;
                if (tempSpeed <= MaxSpeed)
                {
                    Speed = tempSpeed;
                    IsMoving = true;
                }
                else if (tempSpeed > MaxSpeed)
                    Console.WriteLine("Your motorbike can't go faster than 350 km/h");
            }
        }

        public override void Decelerate(int speed)
        {
            if (IsStarted && speed > 0)
            {
                int tempSpeed = Speed -= speed;
                if (tempSpeed > 0)
                    Speed = tempSpeed;
                else if (tempSpeed < 0)
                {
                    Speed = 0;
                    IsMoving = false;
                }

            }
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.motorbike} / {EnvironmentEnum.Land} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the car moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Number of wheels: {WheelNum}";
    }
}
