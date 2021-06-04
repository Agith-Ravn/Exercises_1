using System;

namespace Oppgave8._3
{
    public class BoardModel
    {
        //Array
        public CellModel[] Cells { get; }

        private readonly Random _random = new Random();

        //constructor
        public BoardModel()
        {
            //9 objecter i array. 1 for hver rute
            Cells = new CellModel[9];
            for (int i = 0; i < Cells.Length; i++)
            {
                Cells[i] = new CellModel();
            }
        }


    }


}