using System;
using System.Threading;

namespace Oppgave8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardModel = new BoardModel();

            while (true)
            {
                BoardView.Show(boardModel);
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();

                //Hva gjør disse under?
                var col = position[0] - 'a';
                var row = position[1] - '1';
                var index = row * 3 + col;

                boardModel.SettSpiller1(index);
                BoardView.Show(boardModel);
                Thread.Sleep(700);
                var success = boardModel.SettRandomSpiller2();

                //Hvis SettRandomSpiller2 returnerer false, stop
                if (!success) return;
            }


        }
    }
}
