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
            switch (source)
            {
                case Ship:
                    double kmh = KnotsToKmh((Ship)source);
                    double ms = KnotsToMs((Ship)source);
                    Console.WriteLine("speed in kmh " + kmh);
                    Console.WriteLine("speed in m/s " + ms);
                    break;
                case Motorboat:
                    kmh = KnotsToKmh((Motorboat)source);
                    ms = KnotsToMs((Motorboat)source);
                    Console.WriteLine("speed in kmh " + kmh);
                    Console.WriteLine("speed in m/s " + ms);
                    break;
                case Boat:
                    kmh = KnotsToKmh((Boat)source);
                    ms = KnotsToMs((Boat)source);
                    Console.WriteLine("speed in kmh " + kmh);
                    Console.WriteLine("speed in m/s " + ms);
                    break;
                case Hovercraft:
                    kmh = KnotsToKmh((Hovercraft)source);
                    ms = KnotsToMs((Hovercraft)source);
                    Console.WriteLine("speed in kmh " + kmh);
                    Console.WriteLine("speed in m/s " + ms);
                    break;
                case Amphibian:
                    kmh = KnotsToKmh((Amphibian)source);
                    ms = KnotsToMs((Amphibian)source);
                    Console.WriteLine("speed in kmh " + kmh);
                    Console.WriteLine("speed in m/s " + ms);
                    break;
                case Bike:
                    double knots = KmhToKnots((Bike)source);
                    ms = KmhToMs((Bike)source);
                    Console.WriteLine("speed in m/s " + ms);
                    Console.WriteLine("speed in knots " + knots);
                    break;
                case Car:
                    knots = KmhToKnots((Car)source);
                    ms = KmhToMs((Car)source);
                    Console.WriteLine("speed in m/s " + ms);
                    Console.WriteLine("speed in knots " + knots);
                    break;
                case ElectricBoard:
                    knots = KmhToKnots((ElectricBoard)source);
                    ms = KmhToMs((ElectricBoard)source);
                    Console.WriteLine("speed in m/s " + ms);
                    Console.WriteLine("speed in knots " + knots);
                    break;
                case MotorBike:
                    knots = KmhToKnots((MotorBike)source);
                    ms = KmhToMs((MotorBike)source);
                    Console.WriteLine("speed in m/s " + ms);
                    Console.WriteLine("speed in knots " + knots);
                    break;
                case Airplane:
                    kmh = MsToKmh((Airplane)source);
                    knots = MsToKnots((Airplane)source);
                    Console.WriteLine("speed in kmh " + kmh);
                    Console.WriteLine("speed in knots " + knots);
                    break;
                case Helicopter:
                    kmh = MsToKmh((Helicopter)source);
                    knots = MsToKnots((Helicopter)source);
                    Console.WriteLine("speed in kmh " + kmh);
                    Console.WriteLine("speed in knots " + knots);
                    break;
            }

        }
    }
}
