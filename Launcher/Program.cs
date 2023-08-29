using VehiclesLibrary;
using VehiclesLibrary.LandVehicles;
using VehiclesLibrary.WaterVehicles;

class Program
{
    public static void Main(string[] args)
    {
        Bike bike = new Bike(null);
        UnitConverter unitConverter = new UnitConverter();

        bike.Accelerate(15);

        bike.UnitConverter += unitConverter.OnUnitConverter;
        bike.ShowSpeed(unitConverter);

    }
}
