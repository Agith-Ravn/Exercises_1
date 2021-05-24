using System;

namespace Oppgave6._2
{
    public class Match
    {
        public int homeGoals = 0;
        public int awayGoals = 0;

        //Alle har tilgang til å hente verdi (get), men sette verdi er private (innenfor samme class)
        public bool IsRunning { get; private set; }

        //holder det du tippet her
        public string _bet;

        public Match(string bet)
        {
            _bet = bet;
            IsRunning = true;
        }

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
            IsRunning = false;
        }

        //HUSK Å SETTE DATATYPE NÅR DU SKAL RETURNERE!
        public bool CheckMatchResult()
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            return _bet.Contains(result);
        }
        public string GetScore()
        {
            return homeGoals + "-" + awayGoals;
        }

    }
}