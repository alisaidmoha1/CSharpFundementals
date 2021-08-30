using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console
{
    class Program
    {
        //args = array of options or commands you can type after the name of the program
        static void Main(string[] args)
        {
            //This is where you set up the app, deal with input, etc

            ProgramUI ui = new ProgramUI();
            ui.Run();

        }
    }
}
