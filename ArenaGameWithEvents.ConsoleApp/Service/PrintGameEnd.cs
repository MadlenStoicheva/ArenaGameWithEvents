using ArenaGameWithEvents.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.ConsoleApp.Service
{
    public class PrintGameEnd
    {
        public void PrintEnd(object source, GameEndEventArgs arg)
        {
            Console.WriteLine();
            Console.WriteLine(arg.Information);
        }
    }
}
