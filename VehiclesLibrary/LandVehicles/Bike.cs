using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary.LandVehicles
{
    public class Bike : LandVehicle
    {
        public int MaxSpeed { get; } = 50;
        public Bike(string brand)
        {
            IsStarted = true;
            IsEngineVehicle = false;
            WheelNum = 2;
            Fuel = null;
            Brand = brand;
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
                    Console.WriteLine("Your car can't go faster than 350 km/h");
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

        public override string ToString() => $"Vehicle type and environment: {VehicleType.bike} / {EnvironmentEnum.Land} \n  Brand: {Brand} \n" +
            $"Is the car moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Number of wheels: {WheelNum}";
    }
}
