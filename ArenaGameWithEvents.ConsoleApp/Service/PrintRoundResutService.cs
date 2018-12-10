using ArenaGameWithEvents.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.ConsoleApp.Service
{
    public class PrintRoundResutService
    {
        public void RoundResult (object source, RoundResultEventArgs arg)
        {
            Console.WriteLine(arg.HeroOne.GetType().Name +" " + arg.Information + " " + arg.HeroTwo.GetType().Name + " " + arg.HealthPoints);
        }
    }
}
