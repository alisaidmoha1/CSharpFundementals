using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
        // 1- Access modifier => Visibility in the program
        // 2- Return type => what the method gives back
        // 3- name => uses pascalCase
        // 4 - Parameters => What we need to pass to the method
        // 5- Statements or method body => Code executed
    {    // 1   2     3           4
        public void SayHello(string name)
        {
            //5
            Console.WriteLine($"Hello {name}");
        }

        public void SayHello()
        {   //Overload, same name differen signature - Singnature is the name and the parameters.
            Console.WriteLine("Hello stranger!");
        }

        Random randy = new Random();

        public void RandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "Hi", "Greetings", "Sup", "Good Afternoon", "Howdy" };
            int randomNumber = randy.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings[randomNumber];
            Console.WriteLine(randomGreeting);
        }
    }
}
