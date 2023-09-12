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
        /// <summary>
        /// Accelerates the vehicle speed by the number given in parameter
        /// </summary>
        /// <param name="speed"></param>
        public abstract void Accelerate(int speed);
        /// <summary>
        /// Decelerates the vehicle speed by the number given in parameter
        /// </summary>
        /// <param name="speed"></param>
        public abstract void Decelerate(int speed);
    }

    
}
