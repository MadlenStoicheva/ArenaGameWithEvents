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

            var gameEngineEncoder = new GameEngineEncode();

            var roundResult = new Service.PrintRoundResutService();
            var printDeadHero = new Service.PrintDeadHero();
            var printDeffending = new Service.PrintDeffending();

            Assassian assassian = new Assassian();
            Knight knight = new Knight();
            Dwarf dwarf = new Dwarf();

            gameEngineEncoder.ReturnDeffending += printDeffending.DeffendingResult;
            gameEngineEncoder.RoundResult += roundResult.RoundResult;
            gameEngineEncoder.DeadHeroEncoded += printDeadHero.DeadResult;
            gameEngineEncoder.PlayArena(knight, dwarf);


            Console.ReadKey();


        }
    }
}
