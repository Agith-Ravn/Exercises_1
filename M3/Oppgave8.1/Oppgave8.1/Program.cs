using System;
using System.Collections.Generic;
using System.Threading;

namespace Oppgave8._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Gjør om BoardModel class til object
            var boardModel = new BoardModel();

            while (true)
            {
                BoardView.Show(boardModel);
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();
                var col = position[0] - 'a';
                var row = position[1] - '1';
                var index = row * 3 + col;
                boardModel.SetPlayer1(index);
                BoardView.Show(boardModel);
                Thread.Sleep(700);
                var success = boardModel.SetRandomPlayer2();
                if (!success) return;
            }
        }
    }

    public class BoardModel
    {
        public CellModel[] Cells { get; }
        private readonly Random _random;

        public BoardModel()
        {

            Cells = new CellModel[9];
            for (int i = 0; i < Cells.Length; i++)
            {
                Cells[i] = new CellModel();
            }
            _random = new Random();
        }

        public void AddDummyData()
        {
            Cells[0].Mark(true);
            Cells[1].Mark(false);
        }

        public void SetPlayer1(int index)
        {
            Cells[index].Mark(true);
        }

        public bool SetRandomPlayer2()
        {
            var availableIndexes = new List<int>();
            for (int i = 0; i < Cells.Length; i++)
            {
                if (Cells[i].IsEmpty()) availableIndexes.Add(i);
            }

            if (availableIndexes.Count == 0) return false;
            var randomAvailableIndex = _random.Next(0, availableIndexes.Count);
            var index = availableIndexes[randomAvailableIndex];
            Cells[index].Mark(false);
            return true;
        }
    }

    public class BoardView
    {
        public static void Show(BoardModel m)
        {
            Console.Clear();
            Console.WriteLine(
                "  a b c\n" +
                " ┌─────┐\n" +
                "1│" + GetChar(m, 0) + " " + GetChar(m, 1) + " " + GetChar(m, 2) + "│\n" +
                "2│" + GetChar(m, 3) + " " + GetChar(m, 4) + " " + GetChar(m, 5) + "│\n" +
                "3│" + GetChar(m, 6) + " " + GetChar(m, 7) + " " + GetChar(m, 8) + "│\n" +
                " └─────┘");
        }

        private static char GetChar(BoardModel boardModel, int index)
        {
            var cell = boardModel.Cells[index];
            if (cell.IsEmpty()) return ' ';
            return cell.IsPlayer1() ? 'x' : 'o';
        }
    }

    public class CellModel
    {
        /* Vi har bestemt
         * 0 betyr tom
         * 1 betyr player 1
         * 2 betyr player 2
         */
        private int _content;

        public CellModel()
        {
            _content = 0;
        }

        public bool IsEmpty()
        {
            return _content == 0;
        }

        public bool IsPlayer1()
        {
            return _content == 1;
        }

        public void Mark(bool isPlayer1)
        {
            if (!IsEmpty()) return;
            _content = isPlayer1 ? 1 : 2;
        }
    }



}


namespace TrePåRad
{
    enum CellContentType
    {
        Empty = 0,
        Player1 = 1,
        Player2 = 2
    }
}