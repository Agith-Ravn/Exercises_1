using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave1
//Teller alle bokstaver du fyller inn og sorterer dem etter alfabetisk rekkefølge
{
    class Program
    {
        static void Main(string[] args) //
        {
            //var blir Init datatype
            var range = 250;

            //int array som har plass til å holde 250. disse er tomme for nå.
            var counts = new int[range];
            int total = 0;

            //string variable med "something"
            string text = "something";

            //Mens string IKKE er null / empty eller har whitespace, gjør dette:
            //IsNullOrWhiteSpace er en string method
            while (!string.IsNullOrWhiteSpace(text))
            {
                //text får verdi som bruker skriver
                text = Console.ReadLine();

                //foreach in loop. Looper igjennom text og legger ascii verdi i character
                //?? = Null-coalescing operator. Hvis character ikke ekesisterer eller er null, kjør string.Empty
                //string.Empty = zero-length string
                total = UpdateCharCount(text, counts, total);
                
                //Looper igjennom 250 ganger
                for (var i = 0; i < range; i++)
                {
                    //Hvis counts[index] er større enn 0
                    if (counts[i] > 0)
                    {
                        //"ny" variable character
                        //(datatype)verdi | type casting
                        var character = (char)i;

                        //dele total for å finne ut hvor mange prosent hver bokstav har
                        double percentage = 100 * (double)counts[i] / total;

                        //ToString("F2") = En type format når du gjør om double to string
                        //F2 format = 0.00 
                        string outputText = character + " - " + percentage.ToString("F2") + "%";

                        //Posisjon av tekst i command promt - Fortsatt usikker på dette
                        Console.CursorLeft = Console.BufferWidth - outputText.Length - 1;

                        //C# skriver ut:
                        Console.WriteLine(outputText);
                    }
                }
            }
        }

        private static int UpdateCharCount(string text, int[] counts, int total)
        {
            foreach (var character in text.ToLower() ?? string.Empty)
            {
                //(int)character = type casting (konverter char til int)
                counts[(int) character]++;
                total++;
            }

            return total;
        }
    }
}
 