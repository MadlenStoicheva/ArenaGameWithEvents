using ArenaGameWithEvents.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.ConsoleApp.Service
{
    public class PrintDeffending
    {
        public void DeffendingResult(object source , ReturnDeffendingArgs arg)
        {
            Console.WriteLine(arg.Hero.GetType().Name + " " + arg.Information);
        }
    }
}
