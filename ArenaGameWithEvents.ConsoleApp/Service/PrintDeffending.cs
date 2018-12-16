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
        public void AttackAvoided(object source , AttackAvoidedEventArgs arg)
        {
            // Console.WriteLine(arg.Hero.GetType().Name + " " + arg.Information);
            Console.WriteLine(arg.Hero.GetType().Name + " avoided the attack");
        }

        public void AttackAbsorbed(object source, AttackAbsorbedEventArgs arg)
        {
            // Console.WriteLine(arg.Hero.GetType().Name + " " + arg.Information);
            Console.WriteLine(arg.Hero.GetType().Name + " absorbed the attack");
        }
    }
}
