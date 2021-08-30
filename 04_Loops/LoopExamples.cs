using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while(total != 50) // expression that is either true or false
            {
                Console.WriteLine(total++); // one line code instead of two or more.
                //Console.WriteLine(++total); - it adds the number before it uses

                //total = total +1 1;
                // total += 1;
                //total++;
            }

            total = 0; // reset total

            while(true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached");
                    //break out of this loop
                    // intellisense tells us which loop it will break by highlightin it
                    break;
                }
                total++;
            }

            Random rand = new Random();
            int someNumber;
            bool keepLooping = true;

            while(keepLooping)
            {
                //Random is the type, Rand is the class and Random() is the method.
                someNumber = rand.Next(0, 20); // the next The Method 0 to 19, they exclude the maximun

                if (someNumber == 0 || someNumber == 13)
                {
                    // skip to the next al
                    continue;
                }

                Console.WriteLine(someNumber);

                if (someNumber == 15)
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 26;
            // 1- starting point, do this once at the very beginnig
            // 2- Loop condition, keep looping if the condition == true
            // 3 - do this after each loop
            // 4 = The code exuted every loop
            //     1           2              3
            for (int i = 0; i <= studentCount; i++)
            {
                //4
                Console.WriteLine(i);
            }

            string[] students = { "Hani", "Ayman", "Ayuub", "Mohamed" };
                
                for (int i=0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class, {students[i]}");
            }
                // 1- declare type
                // 2- name the item
                // 3- "in" keyword
                // 4- the list
                //         1     2      3    4
                foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            string myName = "SaidAli";
            foreach(char letter in myName)
            {
                if (letter != 'a' && letter != 'e')
                    //These are the same:
                Console.Write(letter + "\n");
                //Console.WriteLine(letter);
            }

            }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                iterator++;
            } while (iterator < 5);
        }

        [TestMethod]
        public void LoopsChallenge()
        {
            string word = "Supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);

            }

        }
        [TestMethod]
        public void LoopsChallenge1()
        {

            string word = "Supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {

                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or an l");
                }

            }


        }

        [TestMethod]
        public void LoopsChallenge2()
        {

            string word = "hahahahahaahahaha";
            int count = 0;
            foreach(char letter in word)
            {
                count++;
            }
            Console.WriteLine(count);

        }
        
    }
}
