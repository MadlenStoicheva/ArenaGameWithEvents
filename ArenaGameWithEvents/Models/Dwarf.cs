using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Dwarf:Hero
    {
        private const int ChanceToBlockTheAttack = 15;
        private const int ChanceToDo150Damage = 15;

        public Dwarf()
        {
            HealthPoints = 220;
            AttackPoints = 190;
            ArmorPoints = 180;
        }

        public override double Attack()
        {
            if (GetRandomPercentChance() <= ChanceToDo150Damage)
            {
                return AttackPoints * 1.5;
            }
            else
            {
                return base.Attack();
            }
        }

        public override double Defence()
        {
            if (GetRandomPercentChance() <= ChanceToBlockTheAttack)
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
