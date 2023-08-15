namespace VehiclesLibrary.LandVehicles
{
    public class LandVehicle : VehiclesAbstract
    {
        public int WheelNum { get; protected set; }
        public enum VehicleType { car, motorbike, bike, scooter, electricBoard }
        public bool IsStarted { get; protected set; } = false;
        public override int MaxSpeed { get; protected set; } = 350;

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