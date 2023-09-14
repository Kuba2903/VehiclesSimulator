﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary.WaterVehicles
{
    [Serializable]
    [DataContract(IsReference = true)]
    public sealed class Motorboat : WaterVehicle
    {
        
        public Motorboat(string brand, int displacement)
        {
            IsEngineVehicle = true;
            Fuel = FuelType.Diesel.ToString();
            Brand = brand;
            Displacement = displacement;
        }

        /// <summary>
        /// Turning the motorboat on
        /// </summary>
        public void StartOn()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                Console.WriteLine("Vehicle is turned on \n");
            }
            else
                IsStarted = false;
        }

        /// <summary>
        /// Turning the motorboat off
        /// </summary>
        public void TurnOff()
        {
            if (IsStarted)
            {
                IsStarted = false;
                Speed = 0;
                Console.WriteLine("Vehicle is turned off \n");
            }
            else
                IsStarted = true;
        }

        public override string ToString() => $"Vehicle type and environment: {VehicleType.motorboat} / {EnvironmentEnum.Water} \n  Brand: {Brand} \n Fuel Type: {Fuel} \n" +
            $"Is the vehicle moving:{IsMoving} \n Max possible speed: {MaxSpeed} \n Actual Speed: {Speed} \n Is it motor engine: {IsEngineVehicle} \n" +
            $"Displacement: {Displacement}";
    }
}
