using ArenaGameWithEvents.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.ConsoleApp.Service
{
    public class PrintDeadHero
    {
        public void DeadResult(object source, DeadHeroEventArgs arg)
        {
            Console.WriteLine(arg.DeadHero.GetType().Name + " is dead!");
        }
    }
}
