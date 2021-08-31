using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Async
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key to make a meal");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen();
            Potato potato = new Potato();

            //Synchronous can't do other tasks
            potato.Peel();

            //asynchronous, so we can do other this
            //async needs to do Tasks
            //Tasks are "jobs" and not actual objects, yet.
            //async always return Task<The Job of Making the Fries, not the Fries object>
            var fries = kitchen.FryPotatoesAsync(potato);

            //Scynchronous
            Hamburger hamburger = kitchen.AssembleHambumger();

            if (!fries.IsCompleted)
                Console.WriteLine("Waiting on fries.");

            //Synchronous, but can't start untill our fries Task<> is finished because we need the result.
            kitchen.ServeMeal(fries.Result, hamburger);
            Console.ReadKey();

        }
    }
}
