using ArenaGame;
using ArenaGameWithEvents.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.Engine
{
    public class GameEngineEncode
    {
        public event EventHandler<ReturnDeffendingArgs> ReturnDeffending;

        public event EventHandler<DeadHeroEventArgs> DeadHeroEncoded;

        public event EventHandler<RoundResultEventArgs> RoundResult;

        public void PlayArena(Hero heroOne, Hero heroTwo)
        {
            while (true)
            {
                OnAttackDeffendingMechanismEncoded(heroOne, heroTwo);

                if (heroTwo.IsHeroDead == true)
                {
                    OnDeadHeroEncoded(heroTwo);
                    break;
                }

                OnAttackDeffendingMechanismEncoded(heroTwo, heroOne);

                if (heroOne.IsHeroDead == true)
                {
                    OnDeadHeroEncoded(heroOne);
                    break;
                }
            }
        }


        public string AttackDeffendingMechanism(Hero heroOne, Hero heroTwo)
        {
            int heroOneAttack = (int)heroOne.Attack();
            int heroTwoDefending = (int)heroTwo.Defence();

            if (heroTwoDefending == -1)
            {
                return heroTwo.GetType().Name + " prevented the attack!";
            }
            else if (heroTwoDefending <= heroOneAttack)
            {
                heroTwo.HealthPoints -= heroOneAttack - heroTwoDefending;
                return heroTwo.GetType().Name + " after attack from " + heroOne.GetType().Name + ": " + heroTwo.HealthPoints;
            }
            else
            {
                return heroTwo.GetType().Name + " absorbed the attack!";
            }
        }

        public string WriteHeroDead(Hero hero)
        {
            return hero.GetType().Name + " is Dead!";
        }


        protected virtual void OnAttackDeffendingMechanismEncoded(Hero heroOne, Hero heroTwo)
        {
            int heroOneAttack = (int)heroOne.Attack();
            int heroTwoDefending = (int)heroTwo.Defence();

            if (heroTwoDefending == -1)
            {
                ReturnDeffending?.Invoke(this, new ReturnDeffendingArgs() { Hero = heroTwo, Information = " prevented the attack!" });
            }
            else if (heroTwoDefending <= heroOneAttack)
            {
                heroTwo.HealthPoints -= heroOneAttack - heroTwoDefending;
                RoundResult?.Invoke(this, new RoundResultEventArgs() { HeroOne = heroTwo, Information = " after attack from ", HeroTwo = heroOne, HealthPoints =heroTwo.HealthPoints });
            }
            else
            {
                ReturnDeffending?.Invoke(this, new ReturnDeffendingArgs() { Hero = heroTwo, Information = " absorbed the attack!" });
            }
        }


        protected virtual void OnDeadHeroEncoded(Hero hero)
        {
            DeadHeroEncoded?.Invoke(this, new DeadHeroEventArgs() { DeadHero = hero });
        }
    }
}
