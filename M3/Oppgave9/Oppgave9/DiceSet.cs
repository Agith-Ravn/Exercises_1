using System.Collections.Generic;
using System.Linq;

namespace Oppgave9
{
    public class DiceSet
    {
        //private Dice[] _dice;

        //public int[] GetValues()
        //{
        //    return null;
        //}

        //privat tom array av Dice (class) som heter _dice
        private readonly Dice[] _dice;

        //Method - Lager 
        public DiceSet()
        {
            _dice = new[]{ new Dice(), new Dice(), new Dice(), new Dice(), new Dice() };
        }

        
        public int[] GetValues()
        {   //?????????????????                 //.ToArray gjør iEnumerable til array
            return _dice.Select(d => d.Number).ToArray();
        }

        public int PointsAsOnePair()
        {
            return 0;
        }


    }
}