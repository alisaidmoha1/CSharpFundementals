using _11_StreamingContentUIRefactor.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StreamingContentUIRefactor
{
    public class Program
    {
        static void Main(string[] args)
        {
            FunConsole console = new FunConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.Run();
        }
    }
}
