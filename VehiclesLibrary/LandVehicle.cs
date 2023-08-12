namespace VehiclesLibrary
{
    public class LandVehicle : IVehicles
    {
        public bool IsMoving { get ; set ; } = false;
        public int Speed { get; set; } = 0;
        public bool IsEngineVehicle { get; set; }
        public int WheelNum { get; protected set; }
        public enum VehicleType {car, motorbike, bike, scooter, electricBoard }
        public enum EnvironmentEnum { Land, Water, Air }
        public enum FuelType { Gas, Diesel, Electric, LPG }
        public bool IsStarted { get; protected set; } = false;
        public string? Brand { get; protected set; }
        public string? Fuel { get; protected set; }
        public virtual void Accelerate(int speed)
        {
            throw new NotImplementedException();
        }

        public virtual void Decelerate(int speed)
        {
            throw new NotImplementedException();
        }

    }
}