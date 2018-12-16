using ArenaGame;
using ArenaGameWithEvents.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameWithEvents.Engine
{
    public class GameEngine
    {
        public event EventHandler<GameStartEventArgs> GameStart;

        public event EventHandler<AttackAvoidedEventArgs> AttackAvoided;

        public event EventHandler<AttackAbsorbedEventArgs> AttackAbsorbed;

        public event EventHandler<DeadHeroEventArgs> DeadHero;

        public event EventHandler<RoundResultEventArgs> RoundResult;

        public event EventHandler<GameEndEventArgs> GameEnd;


        public void PlayArena(Hero heroOne, Hero heroTwo)
        {
            OnGameStart();

            while (true)
            {
                OnAttackDeffendingMechanism(heroOne, heroTwo);

                if (heroTwo.IsDead)
                {
                    OnDeadHero(heroTwo);
                    break;
                }

                OnAttackDeffendingMechanism(heroTwo, heroOne);

                if (heroOne.IsDead)
                {
                    OnDeadHero(heroOne);
                    break;
                }
            }

            OnGameEnd();
        }

        protected virtual void OnGameStart()
        {
            GameStart?.Invoke(this, new GameStartEventArgs() { Information = InformationEnums.GameStart });
        }


        protected virtual void OnAttackDeffendingMechanism(Hero heroOne, Hero heroTwo)
        {
            int heroOneAttack = (int)heroOne.Attack();
            int heroTwoDefending = (int)heroTwo.Defence();

            if (heroTwoDefending == Constants.AttackAvoided)
            {
                AttackAvoided?.Invoke(this, new AttackAvoidedEventArgs() { Hero = heroTwo, Information = InformationEnums.AvoidedTheAttack });
            }
            else if (heroTwoDefending <= heroOneAttack)
            {
                heroTwo.HealthPoints -= heroOneAttack - heroTwoDefending;
                RoundResult?.Invoke(this, new RoundResultEventArgs() { HeroOne = heroTwo, Information = InformationEnums.AfterAttackFrom, HeroTwo = heroOne, HealthPoints = heroTwo.HealthPoints });
            }
            else
            {
                AttackAbsorbed?.Invoke(this, new AttackAbsorbedEventArgs() { Hero = heroTwo, Information = InformationEnums.AbsorbedTheAttack });
            }
        }


        protected virtual void OnDeadHero(Hero hero)
        {
            DeadHero?.Invoke(this, new DeadHeroEventArgs() { DeadHero = hero });
        }

        protected virtual void OnGameEnd()
        {
            GameEnd?.Invoke(this, new GameEndEventArgs() { Information = InformationEnums.GameEnd });
        }
    }
}
