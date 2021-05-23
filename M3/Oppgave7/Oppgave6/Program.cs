using System;

namespace Oppgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output text
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
            
            //Input text
            var betsText = Console.ReadLine();

            //Gjør om class til object -> Sendeer input tekst -> Splitter opp -> legger i array
            var matches = new TwelveMatches(betsText);

            //Kjøres til det finnes en break;
            while (true)
            {
                //Output text
                Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
                
                //Input -> Legger inn i command
                var command = Console.ReadLine();

                //Hvis input er X -> Stop
                if (command == "X") break;

                //Konverter kommando til nummer?
                var matchNo = Convert.ToInt32(command);

                //Output text 
                Console.Write($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
                
                //Input text -> legger inn i team
                var team = Console.ReadLine();

                //Setter i gang AddGoal() method fra TwelveMatches class
                matches.AddGoal(matchNo, team == "H");
                
                //Hviser om du har gjettet riktig eller ikke
                matches.ShowAllScores();

                //Resultat
                matches.ShowCorrectCount();

            }
        }
    }
}
