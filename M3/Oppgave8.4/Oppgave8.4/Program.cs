using System;

namespace Oppgave8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardModel = new BoardModel();
            while (true)
            {
                BoardView.UpdateView(boardModel);
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();
                boardModel.SetCross(position);
                //break;
            }
        }
    }
}
