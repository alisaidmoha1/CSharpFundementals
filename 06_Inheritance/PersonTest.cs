using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            HourlyEmployee employee1 = new HourlyEmployee();
            employee1.HireDate = new DateTime(1990, 1, 5);

            Console.WriteLine($"{employee1.Name} has been with the company for {employee1.YearsWithCompany} years");

            SalaryEmployee employee2 = new SalaryEmployee();
            employee2.SetFirstName("Said");
            employee2.SetLastName("Ali");
            employee2.Salary = 80000m;
            employee2.HireDate = new DateTime(2019, 4, 1);
            Console.WriteLine($"{employee2.Name} is making {employee2.Salary} after {employee2.YearsWithCompany} years.");
        }
    }
}
