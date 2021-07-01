using System;
using System.ComponentModel.Design;

namespace Oppgave18._3
{
    public class CellModel
    {
        /*
         *  0 = Ingenting
         *  1 = x
         *  2 = o
         */

        public int CellContent { get; set; }

        public CellModel()
        {
            CellContent = 0;
        }

        public string GetCellContent()
        {
            if (CellContent == 1) return "×";
            else if (CellContent == 2) return "o";
            else return "-";
        }

        public void MarkX()
        {
            if (CellContent == 0) CellContent = 1;
        }

        public void MarkO()
        {
            if (CellContent == 0) CellContent = 2;
        }


    }
}