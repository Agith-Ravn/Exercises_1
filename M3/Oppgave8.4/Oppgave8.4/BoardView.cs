using System;

namespace Oppgave8._4
{
    public class BoardView
    {
        public static void UpdateView(BoardModel BM)
        {
            Console.Clear();
            Console.WriteLine("     a b c   \n" +
                              "   ┌───────┐ \n" +
                              " 1 │ " + GetCellContent(BM, 0) + " " + GetCellContent(BM, 1) + " " + GetCellContent(BM, 2) + " │ \n" +
                              " 2 │ " + GetCellContent(BM, 3) + " " + GetCellContent(BM, 4) + " " + GetCellContent(BM, 5) + " │ \n" +
                              " 3 │ " + GetCellContent(BM, 6) + " " + GetCellContent(BM, 7) + " " + GetCellContent(BM, 8) + " │ \n" +
                              "   └───────┘ \n");
        }

        public static char GetCellContent(BoardModel boardModel, int index)
        {
            var cell = boardModel.cells[index];
            return cell.InnholdIRute;
        }
    }
}
