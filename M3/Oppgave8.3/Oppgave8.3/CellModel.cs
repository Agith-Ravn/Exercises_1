namespace Oppgave8._3
{
    public class CellModel
    {
        /* 0 betyr tom
         * 1 betyr player 1
         * 2 betyr player 2
         */

        private int innholdIRute;
        
        //constructor
        public CellModel()
        {
            //Alle rutene starter med 0 = tom
            innholdIRute = 0;
        }

        public bool TomRute()
        {
            return innholdIRute == 0;
        }

        public bool Spiller1()
        {
            return innholdIRute == 1;
        }

        public void Mark(bool Spiller1)
        {
            //Hvis rute ikke er tom returner
            if (!TomRute()) return;

            //Hvis rute er tom +
            //hvis den er sant, sjekk spiller om det er sant. send 1 til innholdIRute om det er sant
            //ellers 2 til innholdIRute
            innholdIRute = Spiller1 ? 1 : 2;

            //return innholdIRute == 2;
        }

    }
}