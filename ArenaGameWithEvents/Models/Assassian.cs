using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Assassian : Hero
    {
        private const int ChanceToDo300Damage = 30;

        public Assassian()
        {
            HealthPoints = 250;
            AttackPoints = 220;
            ArmorPoints = 200;
        }

        public override double Attack()
        {
            if (GetRandomPercentChance() <= ChanceToDo300Damage)
            {
                return AttackPoints * 3;
            }
            else
            {
                return base.Attack();
            }
        }
    }
}
