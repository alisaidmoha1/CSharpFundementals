using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Async
{
    public class Potato
    {
        public Potato()
        {
            Ispeeled = false;
        }

        public Potato (bool isPeeled)
        {
            Ispeeled = Ispeeled;
        }
        public bool Ispeeled { get; set; }

        public bool Peel()
        {
            Console.WriteLine("Start peeling the potato");
            //Syncronous,
            //can't do other things
            Task.Delay(2000).Wait();
            Ispeeled = true;
            Console.WriteLine("You peel the potato");
            return true;
        }
    }

    public class Fries
    {
        public Fries (Potato potato)
        {

        }
    }

    public class Hamburger { }
}
