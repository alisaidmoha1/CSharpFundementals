using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenges
{
    [TestClass]
    public class CustomerInfoTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomerInfo cust = new CustomerInfo("Said", "Ali", "Saciidyare50@hotmail.com", 3176295369, "Male", "Indiana");

        }


        [TestMethod]

        public void CalculationsTest()
    {Math m1 = new Math(2, 5);
        }

        [TestMethod]
        public void EmployeeTest()
        {FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.EmployeeFullName();
            FTE.EmployeePhoneNumber();

        }

  }
}
