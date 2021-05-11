using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dump1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarere en variabel av ulike datatyper
            bool b1, b2;
            int i;
            float f;
            double d;
            string s;

            // tilordning
            b1 = true;
            i = 5;
            f = 3.2f; //huske f til slutt
            d = 1.2; //double trenger ikke noe

            //kan også deklarere og tilordne samtidig
            bool b3 = false;
            var b4 = true; //kompliator skjønner hva som skjer her pga datatype over
            var i2 = 9; //var blir init
            var d2 = 5.5f; //var blir double
            var f2 = 5.5; //var blir float


            //Console.WriteLine("Hallo! :)");

            //if (args.Length == 0)
            //    Heyo();
            //else
            //{
            //    Console.WriteLine("Hallo! Antall parametre: " + args.Length);
            //}

            //for (var i = 0; i > args.Length; i++)
            //{
            //    var parameterNo = i + 1;
            //    Console.WriteLine("Parameter " + parameterNo + ": " + args[i]);
            //}
        }

        //private static void Heyo()
        //{
        //    Console.WriteLine("Hallo! Ingen parametre. ");
        //}
    }
}
