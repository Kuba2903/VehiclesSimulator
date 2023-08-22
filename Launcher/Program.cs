using VehiclesLibrary;
using VehiclesLibrary.LandVehicles;
using VehiclesLibrary.WaterVehicles;

class Program
{
    public static void Main(string[] args)
    {
        Hovercraft hovercraft = new Hovercraft(null, 100);
        hovercraft.StartOn();
        hovercraft.Accelerate(20);
        Console.WriteLine(hovercraft);
        hovercraft.SwimOnWater();
        hovercraft.Accelerate(20);
        Console.WriteLine(hovercraft);
        
    }
}
