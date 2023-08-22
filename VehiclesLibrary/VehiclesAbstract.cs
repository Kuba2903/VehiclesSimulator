using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    public abstract class VehiclesAbstract
    {
        public bool IsMoving { get; protected set; } = false;
        public int Speed { get; protected set; } = 0;
        public virtual int MaxSpeed { get; protected set; }
        public enum EnvironmentEnum { Land, Water, Air}
        public bool IsEngineVehicle { get; protected set; }
        public enum FuelType { Gas, Diesel, Electric,LPG}
        public string? Brand { get; protected set; }
        public string? Fuel { get; protected set; }
        public abstract void Accelerate(int speed);
        public abstract void Decelerate(int speed);
    }

    
}
