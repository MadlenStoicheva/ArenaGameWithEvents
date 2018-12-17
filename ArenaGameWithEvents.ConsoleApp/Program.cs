using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGame;
using ArenaGameWithEvents;
using ArenaGameWithEvents.Engine;

namespace ArenaGameWithEvents.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a Game in the Arena!");
            Console.WriteLine();

            var gameEngine = new GameEngine();
            var printGame = new Service.PrintGame();

            Assassian assassian = new Assassian();
            Knight knight = new Knight();
            Dwarf dwarf = new Dwarf();

            gameEngine.GameStart += printGame.PrintStart;
            gameEngine.AttackAvoided += printGame.AttackAvoided;
            gameEngine.AttackAbsorbed += printGame.AttackAbsorbed;
            gameEngine.RoundResult += printGame.RoundResult;
            gameEngine.DeadHero += printGame.DeadResult;
            gameEngine.GameEnd += printGame.PrintEnd;

            gameEngine.PlayArena(knight, dwarf);

            Console.ReadKey();
        }
    }
}
