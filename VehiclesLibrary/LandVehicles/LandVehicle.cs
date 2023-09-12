using System.Runtime.Serialization;

namespace VehiclesLibrary.LandVehicles
{
    [Serializable]
    [DataContract (IsReference = true)]
    public class LandVehicle : VehiclesAbstract, IUnitConverterDel, ICloneable
    {
        public int WheelNum { get; protected set; }

        public enum VehicleType { car, motorbike, bike, scooter, electricBoard }
        public bool IsStarted { get; protected set; } = false;
        [DataMember]
        public override int MaxSpeed { get; protected set; } = 350;

        public event IUnitConverterDel.UnitConverterEventHandler UnitConverter;

        /// <summary>
        /// Accelerates the vehicle speed by the number given in parameter
        /// </summary>
        /// <param name="speed">The speed is given in km/h</param>
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

        /// <summary>
        /// Decelerates the vehicle speed by the number given in parameter
        /// </summary>
        /// <param name="speed">The speed is given in km/h</param>
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

        /// <summary>
        /// Shows speed in three different units (km/h, m/s, knots)
        /// </summary>
        /// <param name="converter"></param>
        public void ShowSpeed(UnitConverter converter)
        {
            Console.WriteLine("speed in km/h " + Speed);
            OnUnitConverter(converter);
        }

        object ICloneable.Clone() => this.MemberwiseClone();
        public LandVehicle Clone() => (LandVehicle)this.MemberwiseClone();

        /// <summary>
        /// Makes a copy of the object with the exact same parameters
        /// </summary>
        /// <returns></returns>
        public LandVehicle DeepClone()
        {
            LandVehicle clone = this.Clone();
            return clone;
        }
    }
}