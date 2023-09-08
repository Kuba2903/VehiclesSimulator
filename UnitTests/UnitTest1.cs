using VehiclesLibrary;
using VehiclesLibrary.LandVehicles;
using VehiclesLibrary.WaterVehicles;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAirVehicles()
        {
            Airplane airplane = new Airplane("lufthansa", VehiclesAbstract.FuelType.Diesel);

            airplane.Accelerate(20);

            Assert.AreEqual(0, airplane.Speed);

            airplane.StartOn();
            airplane.Accelerate(30);
            airplane.FlyToTheAir();
            Assert.AreEqual(true, airplane.IsVehicleInAir);

            ///

            Helicopter helicopter = new Helicopter(null, VehiclesAbstract.FuelType.Gas);

            Assert.AreEqual(false, helicopter.IsMoving);
            helicopter.StartOn();
            helicopter.FlyToTheAir();

            helicopter.Accelerate(70);
            helicopter.Decelerate(10);

            Assert.AreEqual(60,helicopter.Speed);
        }

        [TestMethod]
        public void TestLandVehicles()
        {
            Car mercedes = new Car("Mercedes", VehiclesAbstract.FuelType.Electric);

            Assert.AreEqual(4, mercedes.WheelNum);
            Assert.AreEqual(true, mercedes.IsEngineVehicle);

            mercedes.StartOn();

            mercedes.Accelerate(200);
            mercedes.Accelerate(200); //max speed is exceeded

            Assert.AreEqual(200, mercedes.Speed);

            //////

            Bike bike = new Bike(null);

            Assert.AreEqual(2, bike.WheelNum);
            Assert.AreEqual(null, bike.Fuel);
            bike.Accelerate(20);
            Assert.AreEqual(20, bike.Speed);

            /////

            ElectricBoard board = new ElectricBoard(null);

            Assert.AreEqual("Electric", board.Fuel);

        }

        [TestMethod]
        public void TestWaterVehicles()
        {
            Ship ship = new Ship("titanic", 100);

            ship.StartOn();
            ship.Accelerate(35);
            ship.Decelerate(5);
            Assert.AreEqual(30, ship.Speed);
            Assert.AreEqual("Diesel", ship.Fuel);

            /////
            
            Hovercraft hovercraft = new Hovercraft(null, 60);
            
            hovercraft.StartOn();

            hovercraft.Accelerate(30);
            hovercraft.Accelerate(5); //max speed for land environment exceeded
            Assert.AreEqual(30,hovercraft.Speed);

            hovercraft.SwimOnWater();

            hovercraft.Accelerate(10);
            Assert.AreEqual(40,hovercraft.Speed);
            hovercraft.TurnOff();
            Assert.AreEqual(false, hovercraft.IsStarted);
            Assert.AreEqual(0, hovercraft.Speed);

            /////


            Amphibian amphibian = new Amphibian(null, 40);

            Assert.AreEqual(false, amphibian.IsEngineVehicle);
            Assert.AreEqual(false, amphibian.IsMoving);
            Assert.AreEqual(40, amphibian.Displacement);
        }

        [TestMethod]
        public void TestUnitConversion()
        {
            Car bmw = new Car("bmw", VehiclesAbstract.FuelType.Gas);
            bmw.StartOn();
            bmw.Accelerate(150);
            int knots = (int)UnitConverter.KmhToKnots(bmw);
            int ms = (int)UnitConverter.KmhToMs(bmw);

            Assert.AreEqual(80, knots);
            Assert.AreEqual(41, ms);

            Helicopter helicopter = new Helicopter(null, VehiclesAbstract.FuelType.Diesel);
            helicopter.StartOn();
            helicopter.FlyToTheAir();
            helicopter.Accelerate(120);

            int km = (int)UnitConverter.MsToKmh(helicopter);
            int knots2 = (int)UnitConverter.MsToKnots(helicopter);

            Assert.AreEqual(432,km);
            Assert.AreEqual(233,knots2);


            Amphibian amphibian = new Amphibian(null, 50);
            amphibian.Accelerate(10);

            int km2 = (int)UnitConverter.KnotsToKmh(amphibian);
            int ms2 = (int)UnitConverter.KnotsToMs(amphibian);

            Assert.AreEqual(18, km2);
            Assert.AreEqual(5, ms2);
            
        }
    }
}