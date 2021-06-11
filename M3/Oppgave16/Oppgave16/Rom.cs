namespace Oppgave16
{
    class Rom
    {
        //Lagrer navn, innhold, start, vunnet
        public string navn;
        public string[] innhold;
        public bool start;
        public bool vunnet;

        //
        public string hentInnhold()
        {
            return string.Join("\n", innhold);
        }
    }
}