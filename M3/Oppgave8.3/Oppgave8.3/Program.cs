using System;

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
                boardModel.SetCross(position);
            }


        }
    }
}
