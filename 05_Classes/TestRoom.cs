using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class TestRoom
    {
        [TestMethod]
        public void TestRooms()
        {
            Room room = new Room(0, 0, 0);
            double result = room.CalculateSquare();
            Console.WriteLine(result);

            Console.WriteLine(room.Length);
        }
    }
}
