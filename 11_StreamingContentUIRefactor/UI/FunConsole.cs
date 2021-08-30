using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_StreamingContentUIRefactor.UI
{
    public class FunConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
            Random randy = new Random();
            int colorIndex = randy.Next(0, 16);

            Console.BackgroundColor = (ConsoleColor)colorIndex;
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {

            string input = Console.ReadLine();
            Console.WriteLine("Umm...");
            Thread.Sleep(100);
            Console.WriteLine("Okay...");
            Thread.Sleep(100);
            return input;
        }

        public void Write(string s)
        {
            Console.Write(s.ToUpper());
        }

        public void WriteLine(string s)
        {
            Random randy = new Random();
            int colorIndex = randy.Next(0, 16);
            Console.ForegroundColor = (ConsoleColor)colorIndex;

            bool capitalize = false;
            foreach(char letter in s)
            {
                if (capitalize)
                {   // Chained two method class since char cannot be upper
                    Console.WriteLine(letter.ToString().ToUpper());
                    capitalize = false;
                }else
                {   //another way to user char toLower or to Upper
                    Console.WriteLine(char.ToLower(letter));
                    capitalize = true;
                }
            }

            Console.Write('\n');

            Thread.Sleep(50);
        }

        public void WriteLine(object o)
        {
            throw new NotImplementedException();
        }

    }
}
