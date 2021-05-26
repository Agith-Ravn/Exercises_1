using System;

namespace Oppgave9
{
    public class Dice
    {
        public int Number { get; private set; }

        public void Roll()
        {
                        //Hvorfor .instance.GetRandom??
            Number = YatzyRandom.Instance.GetRandomDiceNumber();
        }
    }
}