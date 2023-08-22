using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary.WaterVehicles
{
    public class WaterVehicle : VehiclesAbstract
    {
        //speed measured in knots
        public override int MaxSpeed { get; protected set; } = 40;
        public int Displacement { get; set; }

        public enum VehicleType {ship, boat, motorboat, hovercraft, amphibian}
        public bool IsStarted { get; protected set; } = false;

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
