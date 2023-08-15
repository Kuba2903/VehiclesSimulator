using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    public class AirVehicles : VehiclesAbstract
    {
        public override int MaxSpeed { get; protected set; } = 200;
        public int MinSpeed { get; set; } = 20;
        public enum VehicleType { airplane, helicopter }
        public bool IsStarted { get; protected set; } = false;
        public bool IsVehicleInAir { get; set; } = false;

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
            if (IsStarted && !IsVehicleInAir)
            {
                IsStarted = false;
                IsMoving = false;
                Speed = 0;
                Console.WriteLine("Vehicle is off");
            }
        }
        public override void Accelerate(int speed)
        {
            if (IsStarted && speed > 0)
            {
                int tempSpeed = Speed;
                tempSpeed += speed;

                if (tempSpeed <= MaxSpeed)
                {
                    Speed = tempSpeed;
                    IsMoving = true;
                }
                if (tempSpeed > MaxSpeed)
                    Console.WriteLine("Your vehicle can't go any faster");
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
    }
}
