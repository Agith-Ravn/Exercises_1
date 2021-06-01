namespace Oppgave10._5
{
    class Match
    {
        public int homeGoals { get; private set; }
        public int awayGoals { get; private set; }
        private readonly string bet;
        public bool IsRunning { get; private set; }

        //constructor
        public Match(string bet)
        {
            this.bet = bet;
            IsRunning = true;
        }

        public void AddGoal(string? command)
        {
            if (command == "H")
            {
                homeGoals++;
            }
            if (command == "B")
            {
                 awayGoals++;
            }
        }

        public string IsBetCorrect(string result)
        {
            var isBetCorrectText = "";
            var isBetCorrect = bet.Contains(result);
            return isBetCorrectText = isBetCorrect ? "riktig" : "feil";

        }

        public void Stop(string? command)
        {
            if (command != "X")
            {
                IsRunning = false;
            }
        }

        public string GetScore()
        {
            return homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
        }
    }
}