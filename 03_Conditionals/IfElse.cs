using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungary = true;
            // if keyword
            // if (conditional in parantheses)
            //{statement in brackets)
            if(userIsHungary)
            {
                Console.WriteLine("You should eat something");
            }

            bool didYouStudy = false;

            if (!didYouStudy)
            {
                Console.WriteLine("You should've studied!");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;

            if (choresAreDone)
            {
                Console.WriteLine("Have at the movies!");
            } else
            {
                Console.WriteLine("You must stay home and finish your chores!");
            }

            // Nesting Conditionals
            string input = "7";
            int totalSleep = int.Parse(input);
            if (totalSleep >= 8)
            {
                Console.WriteLine("You should be well rested");
            } else
            {
                Console.WriteLine("You might be tired today");
                if (totalSleep < 4)
                {
                    Console.WriteLine("You should get more sleep");
                }
            }

        }

        [TestMethod]
        public void IfElseIF()
        {
            int age = 55;

            if (age >17)
            {
                Console.WriteLine("You are an adult");
            } else
            {
                Console.WriteLine("You are underage");

                if (age > 6)
                {
                    Console.WriteLine("You are a kid");
                } else if ( age > 0)
                {
                    Console.WriteLine(" You are too young to use a computer");
                } else
                {
                    Console.WriteLine("You are not born yet");
                }
            }

            if (age >=55)
            {
                Console.WriteLine("Senior discount time");
            } else if (age >21 && age <55){
                Console.WriteLine("You are an adult");
            } else if (age == 21)
            {
                Console.WriteLine("You can drink now!");
            } else if (age <= 19) {
                Console.WriteLine("You are teenager, or will be soon");
            } else
            {
                Console.WriteLine("You must be 20!");
            }
        }
    }
}
