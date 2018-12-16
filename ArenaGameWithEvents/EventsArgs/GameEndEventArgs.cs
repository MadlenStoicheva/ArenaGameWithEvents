using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.EventsArgs
{
    public class GameEndEventArgs : EventArgs
    {
        public InformationEnums Information { get; set; }
    }
}
