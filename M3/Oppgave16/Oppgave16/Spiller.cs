using System.Collections.Generic;

namespace Oppgave16
{
    class Spiller
    {
        //Lagrer liste over ting du har
        public List<string> har;

        //Hvilken rom du er i
        public Rom rom;

        //Construktor - Lager bare en ny liste
        public Spiller()
        {
            har = new List<string>();
        }

        //returnerer verdiene fra "har" liste + legger til \n = ny linje på starten
        public string inventory()
        {
            return string.Join("\n", har);
        }
    }
}