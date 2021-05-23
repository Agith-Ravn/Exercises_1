using System;

namespace Oppgave6._2
{
    public class OutputText
    {
        public void Info()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
        }

        public void AddGoalInfo()
        {
            Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
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