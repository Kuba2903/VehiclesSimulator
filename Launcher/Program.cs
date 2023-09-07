using VehiclesLibrary;
using VehiclesLibrary.LandVehicles;
using VehiclesLibrary.WaterVehicles;
using System.Xml;
using System.Xml.Serialization;
using VehiclesLibrary.Data;
using VehiclesLibrary.Models;

class Program
{
    public static void Main(string[] args)
    {
        


        using VehiclesContext context = new VehiclesContext();
        Airplane airplane = new Airplane("lot", VehiclesAbstract.FuelType.Diesel);
        AirVehiclesModel air = new AirVehiclesModel()
        {
            Brand = airplane.Brand,
            VehicleType = "airplane",
            FuelType = airplane.Fuel,
            MaxSpeed = (short)airplane.MaxSpeed
        };
        context.AirVehicles.Add(air);
        context.SaveChanges();
        
    }
}
