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
    public sealed class Amphibian : WaterVehicle
    {
        private string Environment { get; set; }

        //the amphibian goes faster on water than on land
        public override int MaxSpeed
        {
            get
            {
                if (Environment == EnvironmentEnum.Land.ToString())
                    return 10;
                else
                    return 40;
            }
            protected set { }
        }
        public Amphibian(string brand, int displacement)
        {
            IsEngineVehicle = false;
            Fuel = null;
            Brand = brand;
            Displacement = displacement;
            Environment = EnvironmentEnum.Land.ToString();
            IsStarted = true;
        }

        /// <summary>
        /// Moves from land to the water
        /// </summary>
        public void SwimOnWater()
        {
            if (Environment == EnvironmentEnum.Land.ToString())
            {
                Environment = EnvironmentEnum.Water.ToString();
            }
        }

        /// <summary>
        /// Moves from water to the land
        /// </summary>
        public void SwimOffToLand()
        {
            if (Environment == EnvironmentEnum.Water.ToString())
            {
                Environment = EnvironmentEnum.Land.ToString();
            }
        }

        

        public override string ToString() => $"Vehicle type and environment: {VehicleType.amphibian} / {Environment} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the vehicle moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Displacement: {Displacement}";
    }
}
