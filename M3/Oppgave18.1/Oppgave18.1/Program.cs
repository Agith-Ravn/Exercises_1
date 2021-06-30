using System;

namespace Oppgave18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            var match = new Match(bet);

            while (match.IsRunning)
            {
                Console.Write("\nKommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                match.AddGoal(command);
                match.GetScore();
            }
            var isBetCorrectText = match.IsBetCorrect();
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}
