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

        public bool tomRute()
        {
            return innholdIRute == 0;
        }

        public bool spiller1()
        {
            return innholdIRute == 1;
        }

        public bool spiller2()
        {
            return innholdIRute == 2;
        }

    }
}