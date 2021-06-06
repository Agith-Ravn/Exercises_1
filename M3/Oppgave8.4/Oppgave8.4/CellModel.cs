using System;

namespace Oppgave8._4
{
    public class CellModel
    {
        public char InnholdIRute = ' ';
        public void SettInnholdIRute(char brikke)
        {
            if (SjekkOmRuteErTom())
            {
                InnholdIRute = brikke;
            }
        }

        private bool SjekkOmRuteErTom()
        {
            //Hvis rute er ' ' (tom) eller IKKE har x eller o
            if (TomRute() && !Spiller1() && !Spiller2()) return true;
            else return false;
        }

        public bool TomRute()
        {
            return InnholdIRute == ' ';
        }

        public bool Spiller1()
        {
            return InnholdIRute == '×';
        }

        public bool Spiller2()
        {
            return InnholdIRute == 'o';
        }


    }
}