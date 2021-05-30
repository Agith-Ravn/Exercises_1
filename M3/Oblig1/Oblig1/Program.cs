using System;

namespace Oblig1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Hjelp();

            var input = Console.ReadLine();

            if (input == "hjelp")
            {
                Hjelp();
            }

        }

        private static void Hjelp()
        {
            Console.WriteLine("Kommandoer: \n \"hjelp\" = viser en hjelpetekst som forklarer alle kommandoene" +
                              "\n \"liste\" = lister alle personer med id, fornavn, fødselsår, dødsår og navn og" +
                              " id på mor og far. \n \"vis <id>\" = viser en bestemt person med mor, far og barn."
            );
        }
    }
}
