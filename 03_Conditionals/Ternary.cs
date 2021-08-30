using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;

            //Variable = (Condition/Boolean) ? trueResul : falseRTesult
            bool isAdult = (age > 17) ? true : false;
            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);
            Console.WriteLine((numOne == 10) ? "True" : "False");

        }
    }
}
