using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PersonPropertyTest()
        {
            Person person = new Person("Said","Ali", new DateTime(1987, 3, 13), "871-88-2965", 800);
          //  person.FirstName = "Said";
          //  person.LastName = "Ali";
          //  person.DateOfBrith = new DateTime(1987, 3, 13);
           // person.SocialSecurity = "231-88- 2981";
          //  person.CreditScore = 810;

            //Console.WriteLine($"{person.FullName} was born on {person.DateOfBrith.ToShortDateString()} \n his social security number is: {person.SocialSecurity}");

            person.Tranport = new Vehicle("Nissan", "GT-R R34", 40000, VehicleType.Car);
            Console.WriteLine($"{person.FirstName} drives a {person.Tranport.Make} {person.Tranport.Model} {person.Tranport.Mileage}");

            Assert.AreEqual("Said A", person.FirstName);

            person.Tranport.TurnOn();

            Assert.IsTrue(person.Tranport.IsRunning);
        }
    }
}
