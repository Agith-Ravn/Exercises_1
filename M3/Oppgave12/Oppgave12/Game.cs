using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessTheNumber
{
    class Game
    {
        //Random number generator
        private static readonly Random Random = new Random();

        //field
        private readonly int _correctNumber;
        private readonly List<Guess> _guesses; //liste for å lagre det du har gjettet

        //hvis _guesses.Count er større enn 0 og (siste) _guesses er riktig
        private bool IsSolved => _guesses.Count > 0 && _guesses.Last().IsCorrect;

        //constructor for Game
        public Game()
        {
            _correctNumber = Random.Next(1, 100); //Henter et tilfeldig tall når du starter spill
            _guesses = new List<Guess>(); //Lager tom liste når du starter spill
        }

        //
        public void GiveUp()
        {
            Console.WriteLine($"Jeg tenkte på tallet {_correctNumber}.");
        }

        public void Guess(int number)
        {
            //Hvis IsSolved er true, stop
            if (IsSolved) return;

            //Hvis ikke > lag ny object med nummberet ditt,
            //sjekk om nummeret ditt er større enn riktige nummber, sjekk om nummeret ditt er lik
            var guess = new Guess(number, number > _correctNumber, number == _correctNumber);

            //Legg til nummeret ditt inn i guess list
            _guesses.Add(guess);
        }


        public void Show()
        {
            //Lagrer antall ganger du har gjettet på forrige runde
            var guessCount = _guesses.Count;

            //Hvis IsSolved er true > returner første string
            //hvis IsSolved er false OG guessCount er 0 > returner andre string
            //hvis IsSolved er false OG guessCount IKKE er 0 > retuner tredje string
            var solvedText = IsSolved ? "Du har funnet det hemmelige tallet - gratulerer!" :
                guessCount == 0 ? "Lykke til med å finne det hemmelige tallet; skriv inn din gjetning." :
                "Du har ikke funnet det hemmelige tallet - prøv igjen!";

            //hvis guessCount er lik 1, bruk "", hvis ikke bruk "er"
            var pluralPrefix = guessCount == 1 ? "" : "er";

            //hvis guessCount er lik 0 bruk "", hvs ikke bruk $"Du har tippet {guessCount} gang{pluralPrefix}."
            var guessNoText = guessCount == 0
                ? ""
                : $"Du har tippet {guessCount} gang{pluralPrefix}.";
            Console.WriteLine(solvedText);
            Console.WriteLine(guessNoText);
            if (guessCount == 0) return;
            Console.WriteLine("Dine gjetninger: ");

            //Går igjennom lista _guesses 
            foreach (var guess in _guesses)
            {
                //sjekker det du gjettet > og mottar om det du har gjettet er riktig eller feil
                Console.WriteLine(guess.Description);
            }
        }
    }
}