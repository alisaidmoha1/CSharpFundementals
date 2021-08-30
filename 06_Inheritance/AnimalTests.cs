using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Animal animal = new Animal();
            //animal.NumOfLegs = 6;

            Mammal nancy = new Mammal();
            Console.WriteLine(nancy.NumOfLegs);
            Console.WriteLine(nancy.HasFur);

            nancy.MakeSound();

            Horse horse = new Horse();
            horse.MakeSound();
            horse.Roar();
            Console.WriteLine(horse.ToString());
        }
    }
}
