using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumber
{
    class Guess
    {
        //field
        private int _number;
        private bool _isTooHigh;
        public bool IsCorrect { get; } //kan kun leses, ikke forandres
        public string Description => $"{_number} er {DescriptionWord}";

        private string DescriptionWord =>
            IsCorrect ? "riktig!" :
            _isTooHigh ? "for høyt" :
            "for lavt";

        public Guess(int number, bool isTooHigh, bool isCorrect)
        {
            _number = number;
            _isTooHigh = isTooHigh;
            IsCorrect = isCorrect;
        }
    }
}