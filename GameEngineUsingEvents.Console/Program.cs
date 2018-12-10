using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGameWithEvents.Engine;

namespace GameEngineUsingEvents.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameEngineEcoder = new GameEngineEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            System.Console.WriteLine();
            System.Console.ReadKey();
        }
    }
}
