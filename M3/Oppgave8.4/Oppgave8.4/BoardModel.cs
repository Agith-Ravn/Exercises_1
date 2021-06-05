using System;
using System.Runtime.InteropServices.ComTypes;

namespace Oppgave8._4
{
    public class BoardModel
    {
        private CellModel[] cells;

        public BoardModel()
        {
            cells = new CellModel[9]; // HUSK Å DEKLARERE HVOR MANGE FØRST!
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new CellModel();
            }
        }

        public void SetCross(string position)
        {
            bool col = position[0] == 'a' || position[0] == 'b' || position[0] == 'c';
            bool row = position[1] == '1' || position[1] == '2' || position[1] == '3';
            if (col && row)
            {
               
            }
            else
            {
                Console.WriteLine("Feil format..");
            }

        }
    }
}