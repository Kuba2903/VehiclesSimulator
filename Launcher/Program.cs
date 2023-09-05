using VehiclesLibrary;
using VehiclesLibrary.LandVehicles;
using VehiclesLibrary.WaterVehicles;
using System.Xml;
using System.Xml.Serialization;

class Program
{
    public static void Main(string[] args)
    {
        Airplane airplane = new Airplane("lot", VehiclesAbstract.FuelType.Diesel);


        airplane.StartOn();
        airplane.Accelerate(5);
        XMLSerialization.SerializeToFile<Airplane>("pliczek2.xml", airplane);

        var c2 = XMLSerialization.DeserializeFromFile<Airplane>("pliczek2.xml");

        Console.WriteLine(c2.Brand);
        
    }
}
