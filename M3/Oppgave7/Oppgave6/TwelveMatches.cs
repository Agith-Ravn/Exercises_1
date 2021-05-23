using System;

namespace Oppgave6
{
    public class TwelveMatches
    {
        //Deklarerer en tom pricate array til senere bruk
        private Match[] _matches;

        public TwelveMatches(string betsText)
        {
            //Deler opp string ved komma og legger inn i bets som array
            var bets = betsText.Split(',');

            //Lager en array med 12 elements, men er tomme..
            _matches = new Match[12];

            //For loop og legger inn hva du tipper i _matches array
            for (var i = 0; i < 12; i++)
            {
                _matches[i] = new Match(bets[i]);
            }
        }


        public void AddGoal(int matchNo, bool isHomeTeam)
        {
            var selectedIndex = matchNo - 1;
            var selectedMatch = _matches[selectedIndex];
            //selectedMatch.AddGoal(isHomeTeam); - Hvorfor er denne her?
        }


        public void ShowAllScores()
        {
            //For loop igjennom matches
            for (var index = 0; index < _matches.Length; index++)
            {
                //match[1], match[2] osv inni match
                var match = _matches[index];

                //Hente matchnr fra index (pga den starter på 0)
                var matchNo = index + 1;

                //Sjekke om hvem som har vunnet + og du har tippet riktig
                var isBetCorrect = match.IsBetCorrect();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";

                //Output 
                Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
            }
        }

        public void ShowCorrectCount()
        {
            var correctCount = 0;
            foreach (var match in _matches)
            {
                //Hvis du har tippet riktig -> legg til i correctCount
                if (match.IsBetCorrect()) correctCount++;
            }
            Console.WriteLine($"Du har {correctCount} rette.");
        }
    }
}