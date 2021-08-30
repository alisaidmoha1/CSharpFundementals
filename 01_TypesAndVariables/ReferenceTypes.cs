using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string declared = "This is Initialized";
            string firstName = "Said";
            string lastName = "Ali";
            //Concatenation
            string concatenedFullName = firstName + " " + lastName; // "Said Ali"
            //Composit Format
            string compositeFormatting = string.Format("{0} {1}", firstName, lastName);
            //Interpolation
            string interpolatedFormating = $"{firstName} {lastName}";
            Console.WriteLine(compositeFormatting);
            Console.WriteLine(concatenedFullName);
            Console.WriteLine(interpolatedFormating);

        }

        [TestMethod]
        public void Collections()
        {
            string greeting = "Greetings";
            // declaring array string. with and string variable
            string[] stringArray = { "Hello", "hi", "Goodbye", greeting };
            //accessing array using
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            //updating array
            stringArray[2] = "Good Morning";
            Console.WriteLine(stringArray[2]);
            //Lists
            List<string> listOfStrings = new List<string>(); // Empty List
            List<int> listOfInt = new List<int>(); // Empty List
            listOfStrings.Add("Here's a string"); // Adding To List of Strings
            listOfStrings.Add("29292");
            listOfInt.Add(7); // Adding to list of Integers.
            //Queue's - first objected added is first object returned
            Queue<string> fisrtInFirstOut = new Queue<string>();
            //enqueue is how to add into queue
            fisrtInFirstOut.Enqueue("I am first");
            fisrtInFirstOut.Enqueue("I am next");
            // Peek method is to access the queue
            Console.WriteLine(fisrtInFirstOut.Peek());
            fisrtInFirstOut.Dequeue();
            Console.WriteLine(fisrtInFirstOut.Peek());
            //stacks - last object added, is firsdt object returned -- first in first out is Ideal for like groceries where things have expiration dates need to go before the newer products

            Stack<string> firstInLastOut = new Stack<string>();
            firstInLastOut.Push("I am a bun");
            firstInLastOut.Push("I am meat");
            firstInLastOut.Push("I am a top bun");
            Console.WriteLine(firstInLastOut.Peek());
            // dictionaries
            Dictionary<string, string> dictionaryDefinition = new Dictionary<string, string>();
            dictionaryDefinition.Add("Duck", "It quacks");
            string definationOfDuck = dictionaryDefinition["Duck"];
            Console.WriteLine(definationOfDuck);
        }
        
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }
    }
}
