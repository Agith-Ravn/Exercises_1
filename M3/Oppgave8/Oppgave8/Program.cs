using System;
using System.Threading.Tasks.Dataflow;

namespace Oppgave8
{

    /*
     * 1. Kjøre program
     * 2. Velge rute
     * 3. update view - tegne opp brettet
     * 4. player 2 velger random
     * 5. update view - tegne opp brettet
     * 6. repeat 2-5 til noen har vunnet
     */
    class Program
    {
        static void Main(string[] args)
        {
            var info = new Info();
            info.GameInfo();

            var view = new View();

            while (true)
            {
                var placement = Console.ReadLine();

                char firstIndex = placement[0];
                char secondIndex = placement[1];

                bool checkFirstIndex = (firstIndex == 'A' || firstIndex == 'B' || firstIndex == 'C');
                bool checkSecondIndex = (secondIndex == '1' || secondIndex == '2' || secondIndex == '3');

                if (checkFirstIndex && checkSecondIndex)
                {
                    //Console.WriteLine("Gyldig");
                    //firstIndex;
                    //secondIndex;
                    var test = new Test();
                    test.PlacePiece(firstIndex, secondIndex);
                    view.UpdateView();
                }
                else
                {
                    Console.WriteLine("Ugyldig plassering, Prøv igjen");
                }
            }
        }
    }

    class Test
    {
        public void PlacePiece(char first, char second)
        {
            var cell = new Cell();

            string test = first.ToString() + second.ToString();
            if (test == "A1") cell.cells[0] = 'x';
            if (test == "B1") cell.cells[1] = 'x';
            if (test == "C1") cell.cells[2] = 'x';
            if (test == "A2") cell.cells[3] = 'x';
            if (test == "B2") cell.cells[4] = 'x';
            if (test == "C2") cell.cells[5] = 'x';
            if (test == "A3") cell.cells[6] = 'x';
            if (test == "B3") cell.cells[7] = 'x';
            if (test == "C3") cell.cells[8] = 'x';
        }
    }

    class Info
    {
        public void GameInfo()
        {
            Console.WriteLine("Tre på rad - Skriv inn hvor du vil sette x. Eksempel A2 osv: \n"+
                "    A  B  C     \n" +
                "  ┌─────────┐   \n" +
                "  │         │ 1 \n" +
                "  │         │ 2 \n" +
                "  │         │ 3 \n" +
                "  └─────────┘ "
                );


            //Console.WriteLine("" +

            //  "    A  B  C     \n" +
            //  "  ┌─────────┐   \n" +
            //  "  │ x  o  o │ 1 \n" +
            //  "  │ o  o  o │ 2 \n" +
            //  "  │ ×  ×  × │ 3 \n" +
            //  "  └─────────┘ "

            //  );
        }
    }

    class Cell
    {                        
                             // 1    2    3    4    5    6    7    8    9
        public char[] cells = {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};

    }

    class View
    {
        public void UpdateView()
        {
            var cell = new Cell();
        
            Console.WriteLine("" +

              "    A  B  C     \n" +
              "  ┌─────────┐   \n" +
              $"  │ {cell.cells[0]}  {cell.cells[1]}  {cell.cells[2]} │ 1 \n" +
              $"  │ {cell.cells[3]}  {cell.cells[4]}  {cell.cells[5]} │ 2 \n" +
              $"  │ {cell.cells[6]}  {cell.cells[7]}  {cell.cells[8]} │ 3 \n" +
              "  └─────────┘ "

            );
        }
    }
}

