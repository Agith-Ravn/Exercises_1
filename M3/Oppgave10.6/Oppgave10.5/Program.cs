using System;

namespace Oppgave10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
            var betsText = Console.ReadLine();
            var matches = new TwelveMatches(betsText);

            while (true)
            {
                Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") break;
                var matchNo = Convert.ToInt32(command);
                Console.Write($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
                var team = Console.ReadLine();

                matches.AddGoal(matchNo, command);
                matches.showAllScores();
                matches.showCorrectScore();
            }
            
            //Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            //var bet = Console.ReadLine();
            //var match = new Match(bet); //Lage en object + sender bet til constructor


            ////var homeGoals = 0;
            ////var awayGoals = 0;

            //while (match.IsRunning)
            //{
            //    Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
            //    var command = Console.ReadLine();

            //    match.Stop(command);
            //    match.AddGoal(command);

            //    Console.WriteLine($"Stillingen er {match.homeGoals}-{match.awayGoals}.");
            //}

            //var result = match.GetScore();            
            //Console.WriteLine($"Du tippet {match.IsBetCorrect(result)}");
        }
    }
}
