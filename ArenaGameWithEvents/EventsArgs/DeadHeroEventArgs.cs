using ArenaGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.Engine
{
    public class DeadHeroEventArgs : EventArgs
    {
        public Hero DeadHero { get; set; }
    }
}
