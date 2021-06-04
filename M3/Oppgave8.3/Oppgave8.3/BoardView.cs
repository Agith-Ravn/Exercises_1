using System;

namespace Oppgave8._3
{
    public class BoardView
    {
        public static void Show(BoardModel m)
        {
            Console.Clear();
            Console.WriteLine(
                "  a b c\n" +
                " ┌─────┐\n" +  //methods inni her som starter, når Show method er "aktivert"
                "1│" + GetChar(m, 0) + " " + GetChar(m, 1) + " " + GetChar(m, 2) + "│\n" +
                "2│" + GetChar(m, 3) + " " + GetChar(m, 4) + " " + GetChar(m, 5) + "│\n" +
                "3│" + GetChar(m, 6) + " " + GetChar(m, 7) + " " + GetChar(m, 8) + "│\n" +
                " └─────┘");
                // ^ GetChar(boardModel, 0) < sender boardModel object + index.
        }

        //Husk! Static blir brukt når du ikke skal lage object/instance av en klasse
        private static GetChar(BoardModel boardModel, int index)
        {
            //Finner riktig object med index
            var cell = boardModel.Cells[index];

            //Setter i gang cell sin method (IsEmpty)
            //Hvis 
            if (cell.IsEmpty()) return ' ';
        }
    }
}