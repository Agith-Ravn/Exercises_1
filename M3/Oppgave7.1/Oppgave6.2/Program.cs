using System;

namespace Oppgave6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lager 12 objects inn i array
            var matches = new Match[12];
            //var match = new Match(); <- trenger ikke denne lenger

            //Egen class object til output
            var outputText = new OutputText();

            //Input felt til alle 12 tipper
            var betsText = Console.ReadLine();

            //Deler opp string ved komma
            var bets = betsText.Split(',');

            //Putter det du tippet for hver kamp inn i hver object
            for (var i = 0; i < 12; i++)
            {
                matches[i] = new Match(bets[i]);
            }

            //Kjøres til det kommer en break;
            while (true)
            {
                outputText.AddGoalInfo();
                var command = Console.ReadLine();

                //Hvis commands er X -> break
                if (command == "X") break;

                //Gjør om commands til nummer
                var matchNo = Convert.ToInt32(command);

                Console.Write($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
                
                //Input som leser hvilken lag du vil tippe på
                var team = Console.ReadLine();

                //Valgt index + valgt kamp
                var selectedIndex = matchNo - 1;
                var selectedMatch = matches[selectedIndex];

                //Legger til mål til valgt team
                selectedMatch.AddGoal(team);

                //Et sted å ha hvor mange riktige du har hatt
                var correctCount = 0;
                for (var index = 0; index < matches.Length; index++)
                {
                    var match = matches[index];
                    var mathNo = index + 1;

                    var isBetCorrect = match.CheckMatchResult();
                    var isBetCorrectText = isBetCorrect ? "riktig" : "feil";

                    if (isBetCorrect) correctCount++;

                    Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
                }

                Console.WriteLine($"Du har {correctCount} rette.");
            }
        }
    }
}