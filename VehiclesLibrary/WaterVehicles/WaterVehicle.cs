using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VehiclesLibrary.LandVehicles;

namespace VehiclesLibrary.WaterVehicles
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class WaterVehicle : VehiclesAbstract, IUnitConverterDel, ICloneable
    {
        //speed measured in knots
        [DataMember]
        public override int MaxSpeed { get; protected set; } = 40;
        [DataMember]
        public int Displacement { get; set; }

        public enum VehicleType {ship, boat, motorboat, hovercraft, amphibian}
        public bool IsStarted { get; protected set; } = false;

        public event IUnitConverterDel.UnitConverterEventHandler UnitConverter;

        public override void Accelerate(int speed)
        {
            if (IsStarted && speed > 0)
            {
                int tempSpeed = Speed;
                tempSpeed += speed;
                if (tempSpeed <= MaxSpeed)
                    Speed = tempSpeed; IsMoving = true;
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
                    Speed = tempSpeed; IsMoving = false;

            }
        }


        protected virtual void OnUnitConverter(UnitConverter converter)
        {
            if (UnitConverter != null)
                UnitConverter(this, EventArgs.Empty);
        }

        public void ShowSpeed(UnitConverter converter)
        {
            Console.WriteLine("speed in knots " + Speed);  
            OnUnitConverter(converter);
        }

        object ICloneable.Clone() => this.MemberwiseClone();
        public WaterVehicle Clone() => (WaterVehicle)this.MemberwiseClone();

        public WaterVehicle DeepClone()
        {
            WaterVehicle clone = this.Clone();
            return clone;
        }
    }
}
