using System;
using System.Text;

namespace Oblig2
{
    /* - Lage et sjakkspill i kommandolinje vinduet
     * - Skal ha sjakkbrett og 2 typer brikker: tårn (rook) og løper (bishop) (ikke andre!)
     * - Du skal lage det slikt at de 2 brikkene får flytte etter sjakkreglene
     *      - Tårn skal bevege seg på langt det vil opp, ned, venstre og høyre.
     *      - Løperen kan bevege seg så langt den vil diagonalt alle sider
     *  - Brikkene kan hoppe over hverandre.
     *  - Brikken kan ikke flyttes på en plass der det allerede eksisterer en brikke
     *  - 
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var board = new Board();

            //var bishop = new Piece("Bishop", "LPR");
            //var rook = new Piece("Rook", "TRN");
            var bishop = new Bishop("LPR");
            var rook = new Rook("TRN");

            board.Set("e4", bishop);
            board.Set("f7", rook);
            while (true)
            {
                board.Show();
                Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
                var positionFrom = Ask("Hvilken rute vil du flytte fra?");
                var positionTo = Ask("Hvilken rute vil du flytte til?");
                board.Move(positionFrom, positionTo);
            }
        }

        private static string Ask(string question)
        {
            Console.Write(question);
            Console.Write(" ");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer)) Environment.Exit(0);
            return answer;
        }
    }
}
