using ArenaGameWithEvents.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.ConsoleApp.Service
{
    public class PrintGameStart
    {
        public void PrintStart(object source, GameStartEventArgs arg)
        {
            Console.WriteLine(arg.Information);
            Console.WriteLine();
        }
    }
}
