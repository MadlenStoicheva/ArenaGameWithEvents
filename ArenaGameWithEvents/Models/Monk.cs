using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Monk : Hero
    {
        private const int ChanceToAvoidTheAttack = 30;

        public Monk()
        {
            HealthPoints = 150;
            AttackPoints = 100;
            ArmorPoints = 90;
        }

        public override double Defence()
        {
            if (GetRandomPercentChance() <= ChanceToAvoidTheAttack)
            {
                return -1;
            }
            else
            {
                return base.Defence();
            }
        }
    }
}
