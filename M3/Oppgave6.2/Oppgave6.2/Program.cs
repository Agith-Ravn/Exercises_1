using System;

namespace Oppgave6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputText = new OutputText();
            var match = new Match();
            outputText.Info();
            var bet = Console.ReadLine();

            while (match.matchIsRunning)
            {
                outputText.AddGoalInfo();
                var command = Console.ReadLine();
                if (command == "X") match.StopMatch();
                match.AddGoal(command);
                OutputText.GoalInfo(match.homeGoals, match.awayGoals);
            }

            match.CheckMatchResult(bet);
            var isBetCorrectText =  match.isBetCorrect ? "riktig" : "feil";
            outputText.ResultInfo(isBetCorrectText);
        }
    }
}
