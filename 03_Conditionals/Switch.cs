using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCase()
        {
            int input = 1;
            switch(input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Hello to you");
                    break;
                case 3:
                case 4:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("Hi, you are odd");
                    break;
                default:
                    Console.WriteLine("Default Reply");
                    break;
            }
        }
    }
}
