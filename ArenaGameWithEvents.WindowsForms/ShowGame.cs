using ArenaGame;
using ArenaGameWithEvents.Engine;
using ArenaGameWithEvents.EventsArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaGameWithEvents.WindowsForms
{
    public partial class ShowGame : Form
    {
        private Hero FirstHero { get; set; }
        private Hero SecondHero { get; set; }

        public ShowGame(Hero heroOne, Hero secondHero)
        {
            InitializeComponent();

            FirstHero = heroOne;
            SecondHero = secondHero;
            GameEngine game = new GameEngine();

            game.GameStart += PrintStart;
            game.RoundResult += RoundResult;
            game.AttackAvoided += AttackAvoided;
            game.AttackAbsorbed += AttackAbsorbed;
            game.DeadHero += DeadResult;
            game.GameEnd += PrintEnd;

            game.PlayArena(FirstHero, SecondHero);
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PrintStart(object source, GameStartEventArgs arg)
        {
            this.listBox_HeroesFight.Items.Add("Game Start");
        }

        public void RoundResult(object source, RoundResultEventArgs arg)
        {
            this.listBox_HeroesFight.Items.Add(arg.HeroOne.GetType().Name + " after attack from " + arg.HeroTwo.GetType().Name + " " + arg.HealthPoints);
        }

        public void AttackAvoided(object source, AttackAvoidedEventArgs arg)
        {
            this.listBox_HeroesFight.Items.Add(arg.Hero.GetType().Name + " avoided the attack");
        }

        public void AttackAbsorbed(object source, AttackAbsorbedEventArgs arg)
        {
            this.listBox_HeroesFight.Items.Add(arg.Hero.GetType().Name + " absorbed the attack");
        }

        public void DeadResult(object source, DeadHeroEventArgs arg)
        {
            this.listBox_HeroesFight.Items.Add(arg.DeadHero.GetType().Name + " is dead!");
        }

        public void PrintEnd(object source, GameEndEventArgs arg)
        {
            this.listBox_HeroesFight.Items.Add("Game End");
        }
    }
}
