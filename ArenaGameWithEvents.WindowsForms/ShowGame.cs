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
            GameEngineEncode game = new GameEngineEncode();

            game.RoundResult += RoundResult;
            game.ReturnDeffending += DeffendingResult;
            game.DeadHeroEncoded += DeadResult;

            game.PlayArena(FirstHero, SecondHero);
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RoundResult(object source, RoundResultEventArgs arg)
        {
            this.listBox_HeroesFight.Items.Add(arg.HeroOne.GetType().Name + " " + arg.Information + " " + arg.HeroTwo.GetType().Name + " " + arg.HealthPoints);
        }

        public void DeffendingResult(object source, ReturnDeffendingArgs arg)
        {
            this.listBox_HeroesFight.Items.Add(arg.Hero.GetType().Name + " " + arg.Information);
        }

        public void DeadResult(object source, DeadHeroEventArgs arg)
        {
            this.listBox_HeroesFight.Items.Add(arg.DeadHero.GetType().Name + " is dead!");
        }
    }
}
