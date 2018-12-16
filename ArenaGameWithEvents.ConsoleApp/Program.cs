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

            var gameStart = new Service.PrintGameStart();
            var roundResult = new Service.PrintRoundResutService();
            var printDeadHero = new Service.PrintDeadHero();
            var printDeffending = new Service.PrintDeffending();
            var gameEnd = new Service.PrintGameEnd();
            

            Assassian assassian = new Assassian();
            Knight knight = new Knight();
            Dwarf dwarf = new Dwarf();

            gameEngine.GameStart += gameStart.PrintStart;
            gameEngine.AttackAvoided += printDeffending.AttackAvoided;
            gameEngine.AttackAbsorbed += printDeffending.AttackAbsorbed;
            gameEngine.RoundResult += roundResult.RoundResult;
            gameEngine.DeadHero += printDeadHero.DeadResult;
            gameEngine.GameEnd += gameEnd.PrintEnd;

            gameEngine.PlayArena(knight, dwarf);


            Console.ReadKey();


        }
    }
}
