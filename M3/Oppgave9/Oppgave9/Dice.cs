using System;

namespace Oppgave9
{
    public class Dice
    {
        public int Number { get; private set; }

        public Dice() : this(6)
        {
        }

        public Dice(int value)
        {
            Number = value;
        }

        public void Roll()
        {
                        //Hvorfor .instance.GetRandom??
            Number = YatzyRandom.Instance.GetRandomDiceNumber();
        }
    }
}