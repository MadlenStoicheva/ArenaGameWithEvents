using ArenaGameWithEvents.Engine;
using ArenaGameWithEvents.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.ConsoleApp.Service
{
    public class PrintGame
    {
        public void PrintStart(object source, GameStartEventArgs arg)
        {
            Console.WriteLine("Game Start:");
            Console.WriteLine();
        }

        public void AttackAvoided(object source, AttackAvoidedEventArgs arg)
        {
            Console.WriteLine(arg.Hero.GetType().Name + " avoided the attack");
        }

        public void AttackAbsorbed(object source, AttackAbsorbedEventArgs arg)
        {
            Console.WriteLine(arg.Hero.GetType().Name + " absorbed the attack");
        }

        public void RoundResult(object source, RoundResultEventArgs arg)
        {
            Console.WriteLine(arg.HeroOne.GetType().Name + " after attack from " + arg.HeroTwo.GetType().Name + " " + arg.HealthPoints);
        }

        public void DeadResult(object source, DeadHeroEventArgs arg)
        {
            Console.WriteLine(arg.DeadHero.GetType().Name + " is dead!");
        }

        public void PrintEnd(object source, GameEndEventArgs arg)
        {
            Console.WriteLine();
            Console.WriteLine("Game End:");
        }
    }
}
