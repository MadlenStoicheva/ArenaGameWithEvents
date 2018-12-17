using ArenaGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.EventsArgs
{
    public class RoundResultEventArgs :EventArgs
    {
        public Hero HeroOne { get; set; }
        public Hero HeroTwo { get; set; }
        public int HealthPoints { get; set; }
    }
}
