using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void PropertiesTest()
        {
            Vehicle firstCar = new Vehicle();

            firstCar.Make = "Nissan";
            Console.WriteLine(firstCar.Make);

            firstCar.Model = "Skyline";
            firstCar.Mileage = 20000;
            firstCar.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine($"My car is a {firstCar.Make} {firstCar.Model} with {firstCar.Mileage} miles on it");
        }

        [TestMethod]
        public void MethodTests()
        {
            Vehicle transport = new Vehicle();
            transport.TurnOn();
            Assert.IsTrue(transport.IsRunning);
            transport.TurnOff();
        }

        [TestMethod]
        public void IndicatorTest()
        {
            Indicator indicator = new Indicator();
            indicator.TurnOn();
            Assert.IsTrue(indicator.IsFlashing);
            indicator.TurnOff();
        }

        [TestMethod]
        public void TurningSignalTests()
        {
            Vehicle myCar = new Vehicle();
            myCar.TurnOff();
            myCar.LeftIndicator = new Indicator();
            myCar.RightIndicator = new Indicator();
            myCar.TurnRight();
            Console.WriteLine("Turning right now");

            CheckIndicators(myCar);

            myCar.TurnLeft();
            Console.WriteLine("Turn Left");
        }

        public void CheckIndicators (Vehicle myCar)
        {

            Console.WriteLine($"Left Indicator: {myCar.LeftIndicator.IsFlashing}");
            Console.WriteLine($"Right Indicator: {myCar.RightIndicator.IsFlashing}");
        }

        [TestMethod]
        public void Constructors()
        {
            // old way, ew gross icky
            Vehicle car = new Vehicle();
            car.Make = "Toyota";
            car.Model = "Corolla";

            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 300000, VehicleType.Spaceship);
            Console.WriteLine(rocket.Make);
            Console.WriteLine(rocket.Model);
        }

    }
}
