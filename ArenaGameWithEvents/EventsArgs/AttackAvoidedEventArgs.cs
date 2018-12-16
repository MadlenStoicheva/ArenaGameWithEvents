using ArenaGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.EventsArgs
{
    public class AttackAvoidedEventArgs : EventArgs
    {
        public Hero Hero { get; set; }
       // public InformationEnums Information { get; set; }

    }
}
