using System;

namespace Oppgave6._2
{
    public class TwelveMatches
    {
        //tom array til senere bruk
        private Match[] _matches;

        int correctCount = 0;

        public TwelveMatches(string betsText)
        {
            //Lager 12 objects inn i array
            _matches = new Match[12];

            //Deler opp string ved komma
            var bets = betsText.Split(',');

            //Putter det du tippet for hver kamp inn i hver object
            for (var i = 0; i < 12; i++)
            {
                _matches[i] = new Match(bets[i]);
            }
        }

        public void AddGoals(int matchNo, string team)
        {
            //Valgt index + valgt kamp
            var selectedIndex = matchNo - 1;
            var selectedMatch = _matches[selectedIndex];

            //Legger til mål til valgt team
            selectedMatch.AddGoal(team);
        }

        public void ShowAllScores(int matchNo)
        {
            for (var index = 0; index < _matches.Length; index++)
            {
                var match = _matches[index];
                var mathNo = index + 1;

                var isBetCorrect = match.CheckMatchResult();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";

                if (isBetCorrect) correctCount++;
                Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
            }
        }

        public void ShowAllCount()
        {
            Console.WriteLine($"Du har {correctCount} rette.");
        }








    }
}