using System;

namespace Oppgave16
{
    class Program
    {
        private static Model model;

        static void Main(string[] args)
        {
            //Henter model object
            model = new Model();

            //looper igjennom dette til det kommer en break
            while (true)
            {
                //Updaterer view
                UpdateView();

                //Spør om kommando
                Console.Write("Angi kommando: ");

                //Lagrer det du skriver
                var command = Console.ReadLine();
            }
        }

        static void UpdateView()
        {
            var spiller = model.spiller;
            var rom = spiller.rom;
            var headerText = rom.vunnet
                ? "Gratulerer - du har fullført spillet! :-)"
                : $"Du er i rom {rom.navn}";
            Console.WriteLine(
                $"{headerText}\n\nI rommet ser du:{rom.hentInnhold()}\n\n" +
                $"Du har:{spiller.inventory()}\n\nDører:\n{model.doors()}");
        }
    }
}
