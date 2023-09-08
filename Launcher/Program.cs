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
        Airplane airplane = new Airplane("lot", VehiclesAbstract.FuelType.Diesel);
        
    }
}
