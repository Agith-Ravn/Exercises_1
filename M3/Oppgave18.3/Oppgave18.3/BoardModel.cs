using System;
using System.Collections.Generic;

namespace Oppgave18._3
{
    public class BoardModel
    {
        public CellModel[] Cells { get; set; }
        private readonly Random random = new Random();
        public bool isRunning;

        public BoardModel()
        {
            isRunning = true;
            Cells = new CellModel[9];
            for (int i = 0; i < Cells.Length; i++)
            {
                Cells[i] = new CellModel();
            }
        }

        public void SetPlayer1(string? position)
        {
            if (position == "a1") Cells[0].MarkX();
            else if (position == "b1") Cells[1].MarkX();
            else if (position == "c1") Cells[2].MarkX();

            else if (position == "a2") Cells[3].MarkX();
            else if (position == "b2") Cells[4].MarkX();
            else if (position == "c2") Cells[5].MarkX();

            else if (position == "a3") Cells[6].MarkX();
            else if (position == "b3") Cells[7].MarkX();
            else if (position == "c3") Cells[8].MarkX();
        }

        public void SetPlayer2(BoardModel b)
        {
            List<int> availableCells = new List<int>();
            for (int i = 0; i < Cells.Length; i++)
            {
                if (Cells[i].CellContent == 0)
                {
                    availableCells.Add(i);
                }
            }
            int randomIndex = random.Next(0, availableCells.Count);

            Cells[randomIndex].MarkO();
        }
    }
}