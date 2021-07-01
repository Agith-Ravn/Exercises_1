using System;
using System.Threading;

namespace Oppgave18._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardModel = new BoardModel();
            while (boardModel.isRunning)
            {
                UpdateView(boardModel);
                Thread.Sleep(700);
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();
                boardModel.SetPlayer1(position);
                UpdateView(boardModel);
                Thread.Sleep(700);
                boardModel.SetPlayer2(boardModel);
            }
        }

        private static void UpdateView(BoardModel boardModel)
        {
            BoardView.Show(boardModel);
        }
    }
}
