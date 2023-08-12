using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesLibrary
{
    public interface IVehicles
    {
        public bool IsMoving { get; set; }
        public int Speed { get; set; }
        public enum EnvironmentEnum { Land, Water, Air}
        public bool IsEngineVehicle { get; set; }
        public enum FuelType { Gas, Diesel, Electric,LPG}

        /*public void StartVehicle();
        public void StopVehicle();*/
        public void Accelerate(int speed);
        public void Decelerate(int speed);

    }


}
