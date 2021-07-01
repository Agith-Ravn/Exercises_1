using System;
using System.Data.SqlTypes;

namespace Oppgave18._2
{
    public class TwelveMatches
    {
        private Match[] _matches { get; set; }
        private int correctCount = 0;
        public bool IsRunning { get; set; }

        public TwelveMatches(string betsText)
        {
            IsRunning = true;
            string[] bets = betsText.Split(',');
            _matches = new Match[12];
            for (var i = 0; i < 12; i++)
            {
                _matches[i] = new Match(bets[i]);
            }
        }

        public void AddGoal(int matchNo, string team)
        {
            var selectedIndex = matchNo - 1;
            var selectedMatch = _matches[selectedIndex];
            selectedMatch.AddGoal(team);
        }

        public void ShowAllScores()
        {
            for (var index = 0; index < _matches.Length; index++)
            {
                var match = _matches[index];
                var matchNo = index + 1;
                var isBetCorrectText = match.IsBetCorrect();
                if (isBetCorrectText == "riktig") correctCount++;
                Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
            }
        }

        public void ShowCorrectCount()
        {
            Console.WriteLine($"Du har {correctCount} rette.");
        }

        public void StopMatches()
        {
            IsRunning = false;
        }
    }
}