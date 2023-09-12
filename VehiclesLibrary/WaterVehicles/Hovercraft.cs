using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary.WaterVehicles
{
    [Serializable]
    [DataContract(IsReference = true)]
    public sealed class Hovercraft : WaterVehicle
    {
        
        private string Environment { get; set; }

        //the hovercraft goes faster on water than on land
        public override int MaxSpeed
        {
            get
            {
                if (Environment == EnvironmentEnum.Land.ToString())
                    return 30;
                else
                    return 40;
            }
            protected set { }
        }
        public Hovercraft(string brand, int displacement)
        {
            IsEngineVehicle = true;
            Fuel = FuelType.Diesel.ToString();
            Brand = brand;
            Displacement = displacement;
            Environment = EnvironmentEnum.Land.ToString();
        }

        /// <summary>
        /// Turning the hovercraft on
        /// </summary>
        public void StartOn()
        {
            if (!IsStarted)
                IsStarted = true;
            else
                IsStarted = false;
        }

        /// <summary>
        /// Turning the hovercraft off
        /// </summary>
        public void TurnOff()
        {
            if (IsStarted)
            {
                IsStarted = false;
                Speed = 0;
            }
            else
                IsStarted = true;
        }

        /// <summary>
        /// Moves from the land to the water
        /// </summary>
        public void SwimOnWater()
        {
            if(Environment == EnvironmentEnum.Land.ToString())
            {
                Environment = EnvironmentEnum.Water.ToString();
            }
        }

        /// <summary>
        /// Moves from water to the land
        /// </summary>
        public void SwimOffToLand()
        {
            if(Environment == EnvironmentEnum.Water.ToString())
            {
                Environment = EnvironmentEnum.Land.ToString();
            }
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.hovercraft} / {Environment} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the vehicle moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Displacement: {Displacement}";
    }
}
