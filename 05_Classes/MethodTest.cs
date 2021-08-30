using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace _05_Classes
{
    [TestClass]
    public class MethodTest
    {
        [TestMethod]
        public void GreetingTest()
        {
            // Instantiating an objet
            Greeter greeter = new Greeter();
            //Calling a mthed from our variable of that object
            greeter.SayHello("Said"); //"Said" is an argument we are passing through the parameter Name
            //Calling our overload method
            greeter.SayHello();

            greeter.RandomGreeting();
            //Thread sleep so we have some space between our random requests since its based on time
            Thread.Sleep(5);
            greeter.RandomGreeting();
            Thread.Sleep(5);
            greeter.RandomGreeting();
        }

        [TestMethod]
        public void Calculation()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(8, 12);
            Assert.AreEqual(20, sum); // test to check if 20 and sum are equal
            double sumTwo = calculator.Add(4.3, 9);
            Assert.AreEqual(13.3, sumTwo);
            int result = calculator.Diff(4, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void AgeCalculations()
        {
            Calculator calculator = new Calculator();
            int age = calculator.CalculateAge(new DateTime(1992, 4, 21));
            Console.WriteLine($"Chris is {age} years old!");
        }
    }

}