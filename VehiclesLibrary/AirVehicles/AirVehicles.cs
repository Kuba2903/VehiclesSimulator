using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VehiclesLibrary.LandVehicles;

namespace VehiclesLibrary
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class AirVehicles : VehiclesAbstract, IUnitConverterDel, ICloneable
    {
        // the speed is measured in m/s
        [DataMember]
        public override int MaxSpeed { get; protected set; } = 200;
        [DataMember]
        public int MinSpeed { get; set; } = 20;
        public enum VehicleType { airplane, helicopter }
        public bool IsStarted { get; protected set; } = false;
        public bool IsVehicleInAir { get; set; } = false;

        public event IUnitConverterDel.UnitConverterEventHandler UnitConverter;

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

        protected virtual void OnUnitConverter(UnitConverter converter)
        {
            if (UnitConverter != null)
                UnitConverter(this, EventArgs.Empty);
        }

        public void ShowSpeed(UnitConverter converter)
        {
            Console.WriteLine("speed in m/s " + Speed);
            OnUnitConverter(converter);
        }

        object ICloneable.Clone() => this.MemberwiseClone();
        public AirVehicles Clone() => (AirVehicles)this.MemberwiseClone();

        public AirVehicles DeepClone()
        {
            AirVehicles clone = this.Clone();
            return clone;
        }
    }
}
