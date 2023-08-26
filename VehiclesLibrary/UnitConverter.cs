using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLibrary.LandVehicles;
using VehiclesLibrary.WaterVehicles;

namespace VehiclesLibrary
{
    public class UnitConverter
    {

        /// Knots
        public static double KnotsToKmh(Amphibian amphibian) => amphibian.Speed * 1.852;

        public static double KnotsToKmh(Boat boat) => boat.Speed * 1.852;

        public static double KnotsToKmh(Hovercraft hovercraft) => hovercraft.Speed * 1.852;
        public static double KnotsToKmh(Motorboat motorboat) => motorboat.Speed * 1.852;
        public static double KnotsToKmh(Ship ship) => ship.Speed * 1.852;



        public static double KnotsToMs(Amphibian amphibian) => Math.Round(amphibian.Speed / 1.9438444924406, 3);
        public static double KnotsToMs(Boat boat) => Math.Round(boat.Speed / 1.9438444924406, 3);
        public static double KnotsToMs(Hovercraft hovercraft) => Math.Round(hovercraft.Speed / 1.9438444924406, 3);
        public static double KnotsToMs(Motorboat motorboat) => Math.Round(motorboat.Speed / 1.9438444924406, 3);
        public static double KnotsToMs(Ship ship) => Math.Round(ship.Speed / 1.9438444924406, 3);





        public static double KmhToMs(Bike bike) => Math.Round( bike.Speed / 3.6,3);
        public static double KmhToMs(Car car) => Math.Round( car.Speed / 3.6,3);
        public static double KmhToMs(ElectricBoard board) => Math.Round( board.Speed / 3.6,3);
        public static double KmhToMs(MotorBike bike) => Math.Round( bike.Speed / 3.6,3);

        public static double KmhToKnots(Bike bike) => Math.Round(bike.Speed * 0.539957, 3);
        public static double KmhToKnots(Car car) => Math.Round(car.Speed * 0.539957, 3);
        public static double KmhToKnots(ElectricBoard board) => Math.Round(board.Speed * 0.539957, 3);
        public static double KmhToKnots(MotorBike bike) => Math.Round(bike.Speed * 0.539957, 3);




        public static double MsToKmh(Airplane airplane) => (airplane.Speed * 3600) / 1000;
        public static double MsToKmh(Helicopter helicopter) => (helicopter.Speed * 3600) / 1000;
        public static double MsToKnots(Airplane airplane) => Math.Round(airplane.Speed * 1.9438452, 3);
        public static double MsToKnots(Helicopter helicopter) => Math.Round(helicopter.Speed * 1.9438452, 3);

        public void OnUnitConverter(object source, EventArgs e)
        {
            if(source is Amphibian amphibian)
            {
                double kmh = KnotsToKmh((Amphibian)source);
                double ms = KnotsToMs((Amphibian)source);
                Console.WriteLine("speed in kmh " + kmh);
                Console.WriteLine("speed in m/s " + ms);
            }

            else if(source is Hovercraft hovercraft)
            {
                double kmh = KnotsToKmh((Hovercraft)source);
                double ms = KnotsToMs((Hovercraft)source);
                Console.WriteLine("speed in kmh " + kmh);
                Console.WriteLine("speed in m/s " + ms);
            }

            else if (source is Boat boat)
            {
                double kmh = KnotsToKmh((Boat)source);
                double ms = KnotsToMs((Boat)source);
                Console.WriteLine("speed in kmh " + kmh);
                Console.WriteLine("speed in m/s " + ms);
            }

            else if (source is Motorboat motorboat)
            {
                double kmh = KnotsToKmh((Motorboat)source);
                double ms = KnotsToMs((Motorboat)source);
                Console.WriteLine("speed in kmh " + kmh);
                Console.WriteLine("speed in m/s " + ms);
            }
            else if (source is Ship ship)
            {
                double kmh = KnotsToKmh((Ship)source);
                double ms = KnotsToMs((Ship)source);
                Console.WriteLine("speed in kmh " + kmh);
                Console.WriteLine("speed in m/s " + ms);
            }

        }
    }
}
