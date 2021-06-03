using System;
using System.Linq;

namespace Oppgave11
{
    class Program
    {
        static void Main(string[] args)
        {

            //!! SKRIV NED DETTE I NOTATER !!
            Rectangle[] rectangle = new Rectangle[]
            {
                new Rectangle(7, 3),
                new Rectangle(7,5),
                new Rectangle(7,5),

            };

            // velger alle rectangle => kjører alle rectangle.Area ?? Usikker på =>
            var totalArea = rectangle.Sum(r => r.Area);
            Console.WriteLine(totalArea);

        }
    }
}
