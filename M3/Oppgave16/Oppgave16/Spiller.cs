using System.Collections.Generic;

namespace Oppgave16
{
    class Spiller
    {
        public List<string> har;
        public Rom rom;

        public Spiller()
        {
            har = new List<string>();
        }

        public string inventory()
        {
            return string.Join("\n", har);
        }
    }
}