using System;

namespace Oppgave6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Egen class object til output
            var outputText = new OutputText();

            outputText.Info();

            //Input felt til alle 12 tipper
            var betsText = Console.ReadLine();

            //???
            var matches = new TwelveMatches(betsText);


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

                    matches.AddGoals(matchNo, team);
                    matches.ShowAllScores(matchNo);
                    matches.ShowAllCount();
                }
        }
    }
}