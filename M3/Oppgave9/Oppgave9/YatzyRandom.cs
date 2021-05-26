using System;

namespace Oppgave9
{
    public class YatzyRandom
    {
        //Singleton - Gjør det mulig å kun lage 1 instance av YatzyRandom?
        private static YatzyRandom _instance = null;
        public static YatzyRandom Instance
        {
            get
            {
                if (_instance == null) _instance = new YatzyRandom();
                return _instance;
            }
        }

        readonly Random _random = new Random();

        public int GetRandomDiceNumber()
        {
            return _random.Next(1, 6);
        }
    }
}