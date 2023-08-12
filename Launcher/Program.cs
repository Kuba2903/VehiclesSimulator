using VehiclesLibrary;
using VehiclesLibrary.LandVehicles;

class Program
{
    public static void Main(string[] args)
    {
        Car bmw = new Car("bmw", LandVehicle.FuelType.Diesel);
        Console.WriteLine(bmw);
        
        bmw.StartOn();
        bmw.Accelerate(100);
        Console.WriteLine(bmw.Speed);
        Console.WriteLine(bmw);
    }
}
