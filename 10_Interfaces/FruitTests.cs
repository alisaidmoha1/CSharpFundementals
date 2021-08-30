using _10_Interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _10_Interfaces
{
    [TestClass]
    public class FruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            // Can still declare as IFruit but can't make a new instance of Ifruit
            IFruit banana = new Banana(); 
            string output = banana.Peel();
            Console.WriteLine(output);

            Assert.IsTrue(banana.IsPeeled);

        }

        [TestMethod]
        public void InterfacesInCollections() 
        {
            //Orange uses more than our interface, so calling it orange to keep access to extra properties and methods. For example if we use IFruit we could not get Squeeze method.
            Orange orange = new Orange();

            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Grape(),
                orange

            };

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());

                Assert.IsInstanceOfType(fruit, typeof(IFruit));

                //fruit.Squeeze();
                //Does'nt work because treated as IFruit in collection
            }

            Console.WriteLine(orange.Squeeze());
            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);
            Console.WriteLine(output);

            Assert.IsTrue(output.Contains("This fruit is called Grape"));
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()

            };

            foreach (var fruit in fruitSalad)
            {
                //using is keyword
                if (fruit is Orange orange) // this is called pattern matching
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("Is a peeled orange");
                        Console.WriteLine(orange.Squeeze());
                    }
                    else
                        Console.WriteLine("Is an orange");

                } else if (fruit.GetType() == typeof(Grape))
                    {
                    Console.WriteLine("It's a grape");
                    // without pattern matching we need to cast
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());

                    }
                else if (fruit.IsPeeled)
                    Console.WriteLine("Is a peeled banana.");
                else
                    Console.WriteLine("Its a banana");
            }
        }
    }
}
