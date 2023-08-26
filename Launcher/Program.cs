using VehiclesLibrary;
using VehiclesLibrary.LandVehicles;
using VehiclesLibrary.WaterVehicles;

class Program
{
    public static void Main(string[] args)
    {
        Airplane airplane = new Airplane("lot",VehiclesAbstract.FuelType.Diesel);

        airplane.StartOn();
        airplane.Accelerate(15);

        
        Console.WriteLine(UnitConverter.MsToKnots(airplane));
    }
}
