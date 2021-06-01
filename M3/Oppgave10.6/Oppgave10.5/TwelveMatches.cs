using System;

namespace Oppgave10._5
{
    public class TwelveMatches
    {
        
        private Match[] _matches; //Match array 
        
        //Constructor - Legger 12 match objecter inni _matches array
        public TwelveMatches(string betsText)
        {
            var bets = betsText.Split(',');
            _matches = new Match[12]; //HUSK! Du må deklarere denne først
            for (var i = 0; i < 12; i++)
            {
                _matches[i] = new Match(bets[i]); //Sender "bets[1]" til _matches[1] også oppover..
            }
        }

        public void AddGoal(int matchNo, string command)
        {
            var selectedIndex = matchNo - 1;
            var selectedMatch = _matches[selectedIndex];
            selectedMatch.AddGoal(command);
        }

        public void showAllScores()
        {
            for (var index = 0; index < _matches.Length; index++)
            {
                var match = _matches[index];
                var matchNo = index + 1;
                var isBetCorrect = match.IsBetCorrect();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                //if (isBetCorrect) correctCount++;
                Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
            }
        }

        public void showCorrectScore()
        {
            var correctCount = 0;
            foreach (var match in _matches)
            {
                if (match.IsBetCorrect()) correctCount++;
            }

            Console.WriteLine($"Du har {correctCount} rette.");
        }
    }

}