using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.InteropServices.ComTypes;

namespace Oppgave8._4
{
    public class BoardModel
    {
        public CellModel[] cells;
        private readonly Random random = new Random();

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
                PositionToIndex(position);
            }
            else
            {
                Console.WriteLine("Feil format..");
            }

        }

        private void PositionToIndex(string position)
        {
            if (position == "a1") cells[0].SettInnholdIRute('×');
            if (position == "b1") cells[1].SettInnholdIRute('×');
            if (position == "c1") cells[2].SettInnholdIRute('×');

            if (position == "a2") cells[3].SettInnholdIRute('×');
            if (position == "b2") cells[4].SettInnholdIRute('×');
            if (position == "c2") cells[5].SettInnholdIRute('×');

            if (position == "a3") cells[6].SettInnholdIRute('×');
            if (position == "b3") cells[7].SettInnholdIRute('×');
            if (position == "c3") cells[8].SettInnholdIRute('×');

        }

        public void SetRandomCircle()
        {
            List<int> listeAvTommeRuter = new List<int>();

            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i].TomRute())
                {
                    listeAvTommeRuter.Add(i);
                }
            }

            var index = random.Next(0, listeAvTommeRuter.Count);
            cells[listeAvTommeRuter[index]].SettInnholdIRute('o');
        }
    }
}