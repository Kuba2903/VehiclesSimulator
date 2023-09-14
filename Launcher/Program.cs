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
        WelcomeMessage();
        VehicleSelection();

       
    }
    
    public static void WelcomeMessage()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to the vehicles simulator application!");
        Console.WriteLine("You are going to create your vehicle, first select the type of your vehicle: \n\n");
        Console.WriteLine("1.Air Vehicle");
        Console.WriteLine("2.Land Vehicle");
        Console.WriteLine("3.Water Vehicle \n");
    }

    public static void VehicleSelection()
    {
        var input = int.Parse(Console.ReadLine());

        while (input < 1 || input > 3)
        {
            Console.WriteLine("Wrong selection!");
            input = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Now please select the exact kind of vehicle you wish to create");

        bool isAir = false;
        bool isLand = false;
        bool isWater = false;
        switch (input)
        {
            case 1:
                Console.WriteLine("1.Airplane");
                Console.WriteLine("2.Helicopter");
                isAir = true;
                break;
            case 2:
                Console.WriteLine("1.Car");
                Console.WriteLine("2.Motorbike");
                Console.WriteLine("3.Electric Board");
                Console.WriteLine("4.Bike");
                isLand = true;
                break;
            case 3:
                Console.WriteLine("1.Ship");
                Console.WriteLine("2.Motorboat");
                Console.WriteLine("3.Hovercraft");
                Console.WriteLine("4.Boat");
                Console.WriteLine("5.Amphibian");
                isWater = true;
                break;
        }
        input = int.Parse(Console.ReadLine());

        if (isAir)
        {
            Console.Write("Enter the name (or brand) of your vehicle: ");
            string name = Console.ReadLine();
            AirVehicles vehicle = null;

            switch (input)
            {
                case 1:
                    vehicle = new Airplane(name, VehiclesAbstract.FuelType.Diesel);
                    break;
                case 2:
                    vehicle = new Helicopter(name, VehiclesAbstract.FuelType.Diesel);
                    break;
            }

            if (vehicle != null)
            {
                Console.WriteLine("You created your vehicle! \n");

                while (true)
                {
                    AirVehiclesCommands();
                    int command = int.Parse(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            vehicle.StartOn();
                            break;
                        case 2:
                            vehicle.TurnOff();
                            break;
                        case 3:
                            Console.Write("How much you want to accelerate (in m/s units)? ");
                            int acceleration = int.Parse(Console.ReadLine());
                            vehicle.Accelerate(acceleration);
                            break;
                        case 4:
                            Console.Write("How much you want to decelerate (in m/s units)? ");
                            int decelerate = int.Parse(Console.ReadLine());
                            vehicle.Decelerate(decelerate);
                            break;
                        case 5:
                            if (vehicle is Airplane airplane)
                                airplane.FlyToTheAir();
                            else if (vehicle is Helicopter helicopter)
                                helicopter.FlyToTheAir();
                            break;
                        case 6:
                            if (vehicle is Airplane airplane2)
                                airplane2.LandToTheGround();
                            else if (vehicle is Helicopter helicopter)
                                helicopter.LandToTheGround();
                            break;
                        case 7:
                            UnitConverter converter = new UnitConverter();
                            vehicle.UnitConverter += converter.OnUnitConverter;
                            vehicle.ShowSpeed(converter);
                            break;
                        case 8:
                            Console.WriteLine(vehicle);
                            break;
                        case 9:
                            Console.Write("Enter the name of the file: ");
                            string file = Console.ReadLine();
                            XMLSerialization.SerializeToFile<AirVehicles>(file, vehicle);
                            break;
                        case 10:
                            return;
                    }
                }
            }
        }


        if (isLand)
        {
            Console.Write("Enter the name (or brand) of your vehicle: ");
            string name = Console.ReadLine();
            LandVehicle vehicle = null;

            switch (input)
            {
                case 1:
                    vehicle = new Car(name, VehiclesAbstract.FuelType.Diesel);
                    break;
                case 2:
                    vehicle = new MotorBike(name, VehiclesAbstract.FuelType.Gas);
                    break;
                case 3:
                    vehicle = new ElectricBoard(name);
                    break;
                case 4:
                    vehicle = new Bike(name);
                    break;
            }

            if (vehicle != null)
            {
                Console.WriteLine("You created your vehicle! \n");

                while (true)
                {
                    LandSwimVehiclesCommands();
                    int command = int.Parse(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            if (vehicle is Car car)
                                car.StartOn();
                            else if (vehicle is MotorBike motor)
                                motor.StartOn();
                            else if (vehicle is ElectricBoard board)
                                board.StartOn();
                            break;
                        case 2:
                            if (vehicle is Car c)
                                c.TurnOff();
                            else if (vehicle is MotorBike motor)
                                motor.TurnOff();
                            else if (vehicle is ElectricBoard board)
                                board.TurnOff();
                            break;
                        case 3:
                            Console.Write("How much you want to accelerate (in km/h units)? ");
                            int acceleration = int.Parse(Console.ReadLine());
                            vehicle.Accelerate(acceleration);
                            break;
                        case 4:
                            Console.Write("How much you want to decelerate (in km/h units)? ");
                            int decelerate = int.Parse(Console.ReadLine());
                            vehicle.Decelerate(decelerate);
                            break;
                        case 5:
                            UnitConverter converter = new UnitConverter();
                            vehicle.UnitConverter += converter.OnUnitConverter;
                            vehicle.ShowSpeed(converter);
                            break;
                        case 6:
                            Console.WriteLine(vehicle);
                            break;
                        case 7:
                            Console.Write("Enter the name of the file: ");
                            string file = Console.ReadLine();
                            XMLSerialization.SerializeToFile<LandVehicle>(file, vehicle);
                            break;
                        case 8:
                            return;
                    }
                }
            }
        }

        if (isWater)
        {
            Console.Write("Enter the name (or brand) of your vehicle: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter displacement: ");
            int dis = int.Parse( Console.ReadLine());
            WaterVehicle vehicle = null;

            switch (input)
            {
                case 1:
                    vehicle = new Ship(name, dis);
                    break;
                case 2:
                    vehicle = new Motorboat(name, dis);
                    break;
                case 3:
                    vehicle = new Hovercraft(name,dis);
                    break;
                case 4:
                    vehicle = new Boat(name,dis);
                    break;
                case 5:
                    vehicle = new Amphibian(name,dis);
                    break;
            }

            if (vehicle != null)
            {
                Console.WriteLine("You created your vehicle! \n");

                while (true)
                {
                    LandSwimVehiclesCommands();
                    int command = int.Parse(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            if (vehicle is Hovercraft craft)
                                craft.StartOn();
                            else if (vehicle is Motorboat motor)
                                motor.StartOn();
                            else if (vehicle is Ship ship)
                                ship.StartOn();
                            break;
                        case 2:
                            if (vehicle is Hovercraft craft2)
                                craft2.StartOn();
                            else if (vehicle is Motorboat motor)
                                motor.StartOn();
                            else if (vehicle is Ship ship)
                                ship.StartOn();
                            break;
                        case 3:
                            Console.Write("How much you want to accelerate (in knots units)? ");
                            int acceleration = int.Parse(Console.ReadLine());
                            vehicle.Accelerate(acceleration);
                            break;
                        case 4:
                            Console.Write("How much you want to decelerate (in knots units)? ");
                            int decelerate = int.Parse(Console.ReadLine());
                            vehicle.Decelerate(decelerate);
                            break;
                        case 5:
                            UnitConverter converter = new UnitConverter();
                            vehicle.UnitConverter += converter.OnUnitConverter;
                            vehicle.ShowSpeed(converter);
                            break;
                        case 6:
                            Console.WriteLine(vehicle);
                            break;
                        case 7:
                            Console.Write("Enter the name of the file: ");
                            string file = Console.ReadLine();
                            XMLSerialization.SerializeToFile<WaterVehicle>(file, vehicle);
                            break;
                        case 8:
                            return;
                    }
                }
            }
        }
    }

    public static void AirVehiclesCommands()
    {
        Console.WriteLine("Use the following commands: \n");
        Console.WriteLine("1.Start vehicle");
        Console.WriteLine("2.Turn vehicle off");
        Console.WriteLine("3.Accelerate");
        Console.WriteLine("4.Decelerate");
        Console.WriteLine("5.Soar into the air");
        Console.WriteLine("6.Land to the ground");
        Console.WriteLine("7.Show speed");
        Console.WriteLine("8.All informations");
        Console.WriteLine("9.Save");
        Console.WriteLine("10.Quit");
    }

    public static void LandSwimVehiclesCommands()
    {
        Console.WriteLine("Use the following commands: \n");
        Console.WriteLine("1.Start vehicle");
        Console.WriteLine("2.Turn vehicle off");
        Console.WriteLine("3.Accelerate");
        Console.WriteLine("4.Decelerate");
        Console.WriteLine("5.Show speed");
        Console.WriteLine("6.All informations");
        Console.WriteLine("7.Save");
        Console.WriteLine("8.Quit");
    }


}
