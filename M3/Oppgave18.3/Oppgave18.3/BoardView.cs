using System;

namespace Oppgave18._3
{
    public class BoardView
    {
        public static void Show(BoardModel b)
        {
            Console.Clear();
            Console.WriteLine("    a b c   \n" +
                              "  ┌───────┐ \n" +
                              " 1│ " + UpdateBoard(0, b) + " " + UpdateBoard(1, b) + " " + UpdateBoard(2, b) + " │ \n" +
                              " 2│ " + UpdateBoard(3, b) + " " + UpdateBoard(4, b) + " " + UpdateBoard(5, b) + " │ \n" +
                              " 3│ " + UpdateBoard(6, b) + " " + UpdateBoard(7, b) + " " + UpdateBoard(8, b) + " │ \n" +
                              "  └───────┘ \n");
        }

        private static string UpdateBoard(int i, BoardModel boardModel)
        {
            return boardModel.Cells[i].GetCellContent();
        }
    }
}