using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    [Serializable]
    [DataContract (IsReference = true)]
    public abstract class VehiclesAbstract
    {
        [DataMember]
        public bool IsMoving { get; protected set; } = false;
        [DataMember]
        public int Speed { get; protected set; } = 0;
        [DataMember]
        public virtual int MaxSpeed { get; protected set; }
        public enum EnvironmentEnum { Land, Water, Air}
        [DataMember]
        public bool IsEngineVehicle { get; protected set; }
        public enum FuelType { Gas, Diesel, Electric,LPG}
        [DataMember (Order = 1)]
        public string? Brand { get; protected set; }
        [DataMember (Order = 2)]
        public string? Fuel { get; protected set; }
        public abstract void Accelerate(int speed);
        public abstract void Decelerate(int speed);
    }

    
}
