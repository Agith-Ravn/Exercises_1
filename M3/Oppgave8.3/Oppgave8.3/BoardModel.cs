using System;
using System.Collections.Generic;

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

        public void SettSpiller1(int index)
        {
            Cells[index].Mark(true);
        }

        public bool SettRandomSpiller2()
        {
            var tilgjengeligPlassIndex = new List<int>();
            for (int i = 0; i < Cells.Length; i++)
            {
                if (Cells[i].TomRute()) tilgjengeligPlassIndex.Add(i);
            }

            if (tilgjengeligPlassIndex.Count == 0) return false;
            var tilfeldigLedigIndex = _random.Next(0, tilgjengeligPlassIndex.Count);
            var index = tilgjengeligPlassIndex[tilfeldigLedigIndex];
            Cells[index].Mark(false);
            return true;
        }


    }


}