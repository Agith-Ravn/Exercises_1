using System;

namespace Oppgave6._2
{
    public class Match
    {
        public int homeGoals = 0;
        public int awayGoals = 0;
        public bool matchIsRunning = true;
        public bool isBetCorrect;

        public void AddGoal(string? command)
        {
            Console.WriteLine(command);
            switch (command)
            {
                case "H":
                    homeGoals++;
                    break;
                case "B":
                    awayGoals++;
                    break;
            }
        }

        public void StopMatch()
        {
            matchIsRunning = false;
        }

        public void CheckMatchResult(string? bet)
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            isBetCorrect = bet.Contains(result);
        }


    }
}