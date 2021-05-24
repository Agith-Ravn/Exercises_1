using System;

namespace Oppgave6._2
{
    public class OutputText
    {
        public void Info()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
        }

        public void AddGoalInfo()
        {
            Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
        }

        public static void GoalInfo(int homeGoals, int awayGoals)
        {
            Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
        }

        public void ResultInfo(object isBetCorrectText)
        {
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}