using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans() // PascalCapitiliazation
        {
            //Bools by defualt are false
            //Declared Bool
            bool declared;
            // Assigning Value
            declared = true;

            //Declare then assigned
            bool declareAndInitialized = false; //declareAndInitialized = camelCase
            // Still assign value after initial assignment
            declareAndInitialized = true;
        }

        [TestMethod]
        public void Characters()
        {
            //char uses only single quotation and can hold only one item like letters, numbers, spaces and symbols
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' '; //space
            char specialCharacter = '\n';

        }

        [TestMethod]
        public void WholeNumbers()
        {
            //byte is the smallest whole number
            byte byteMin = 0;
            byte byteMax = 255;
            // Short is 16 digit number
            short shortMin = -32768;
            short shortMax = 32767;
            // integer is the most popular whole number its 32 digits
            int intMin = -2147483648;
            int intMax = 2147483647;
            //Long is 64 digit number
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;

        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.29294895f;
            double doubleExample = 1.2828282; // double is default for decimal numbers
            decimal decimalExample = 1.11717171m;

        }

        enum PastryType { Cake, Cupcake, Eclaire, PetitFour, Croissant};

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType yourPastry = PastryType.Cake;

        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birdthday = new DateTime(1987, 3, 13);

        }
    }
}
