using System;
using System.Threading;

namespace RandomBoxes
{
    class Program
    {   
        //start verdi 
        private static int _width = 50;
        private static int _height = 20;

        static void Main(string[] args)
        {
            //Lager shapes med CreateShapes method og putter inn i array (shapes)
            Shape[] shapes = CreateShapes();
            var n = 20;

            //Postfix decrement, så n minsker med 1 etter hver gang kode er kjørt
            while (n-- > 0)
            {
                //Shoe method (ligger nederst)
                Show(shapes);

                //Går igjennom shapes array
                foreach (var shape in shapes)
                {
                    shape.Move();
                }
                Thread.Sleep(400);
            }
        }

        //Lager shape + returnerer (det er derfor det står "Shape[]" på method
        private static Shape[] CreateShapes()
        {
            //Lager new random seed
            var random = new Random();

            //Lager 5 objecter > legger dem i shapes
            var shapes = new Shape[5];

            shapes[0] = new Text(10, 5, "Hurra!", random);

            for (var i = 0; i < shapes.Length; i++)
            {
                //Hvis random genererer tall 0
                if (random.Next(0, 2) == 0)

                    //Lag shape med width og height (start verdi skrevet øverst)
                    //Send vindere random seed
                    shapes[i] = new Rectangle(random, _width, _height);
                else
                    //Lag shape med height (+ lager med random width senere)
                    //Send vindere random seed
                    shapes[i] = new Triangle(random, _height);
            }
            //returner shape til array
            return shapes;
        }


        private static void Show(Shape[] shapes)
        {
            //Fjerner console (blankt ark)
            Console.Clear();

            //Looper igjen _height verdi (20)
            for (var row = 0; row < _height; row++)
            {
                //Looper igjen _width verdi (50 eller 0-??)
                for (var col = 0; col < _width; col++)
                {
                    //??
                    var hasFoundCharacterToPrint = false;

                    //Går igjennom shapes array
                    foreach (var shape in shapes)
                    {
                        //??
                        var character = shape.GetCharacter(row, col);
                        if (character != null)
                        {

                            Console.Write(character);
                            hasFoundCharacterToPrint = true;
                            break;
                        }
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}