namespace Oppgave6
{
    public class Match
    {
        /* 1. Kommando kanskje?
         * 2. Class 
         * 3. Add Goal
         * 4. Check if bet is correct
         * 5. Stop
         * 6. Hvorfor get score????
         */


        private int _homeGoals;
        private int _awayGoals;
        private readonly string _bet;

        public bool IsRunning { get; private set; }

        public Match(string bet)
        {
            _bet = bet;
            IsRunning = true;
        }

        public void AddGoal(bool isHomeTeam)
        {
            if (isHomeTeam) _homeGoals++;
            else _awayGoals++;
        }

        public bool IsBetCorrect()
        {
            /* Nested ternary Operator = a ? b : c ? d : e
             * a ? b : (c ? d : e)
             * Hvis a er true = b
             * hvis a er false -> sjekk c ? d : e -> hvis c er true = d
             *                                       hvisc er false = e
             *                                       
             * Hvis homeGoals er lik awayGoals = "U"
             * Hvis homeGoals IKKE er lik awayGoals -> sjekk om homeGoals er større enn awayGoals = "H"
             *                                             hvis homeGoals er mindre enn awayGoals = "B"
             */

            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            return _bet.Contains(result);
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public string GetScore()
        {
            //Returnerer variablene med verdier som string
            return _homeGoals + "-" + _awayGoals;
        }
    }
}