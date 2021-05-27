using System.Collections.Generic;
using System.Linq;

namespace Oppgave9
{
    public class DiceSet
    {
        //privat tom array av Dice (class) som heter _dice
        private readonly Dice[] _dice;

        public DiceSet()
        {
            _dice = new[] {new Dice(), new Dice(), new Dice(), new Dice(), new Dice(),};
        }

        //??????????????????????????????????
        public IEnumerable<int> GetValues()
        {   //?????????????????                 //.ToArray gjør iEnumerable til array
            return _dice.Select(d => d.Number).ToArray();
        }
    }
}