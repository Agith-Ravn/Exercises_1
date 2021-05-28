using System;

namespace Oppgave10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int range med 250
            var range = 250;

            int total = 0;
            int total2 = 0;

            //Tom array som kalles for counts med 250 plasser
            //Kunne jo bare skrevet "var counts = new int[250];"?
            var counts = new int[range];

            //string som heter text med "something" inni
            string text = "something";

            //Mens IKKE string inneholder null eller mellromrom = true. 
            //Altså alt under kjøres til while loop er stoppet (false)
            //Console.WriteLine(!string.IsNullOrWhiteSpace(text));
            while (!string.IsNullOrWhiteSpace(text))
            {
                //Venter på tekst
                text = Console.ReadLine();

                //double percentage = 100 * (double)counts[i] / total;

                //Går igjennom text > putter hver bokstav i character, 
                foreach (var character in text.ToUpper())
                {
                    //(int)character) = Konverterer char til int - Unicode
                    //(counts[(int)character]) = Finner plassering av unicode, der du plusser +1 inni arrayElement
                    counts[(int)character]++;
                }

                for (int i = 0; i < counts.Length; i++)
                {
                    total2 += counts[i];
                }
               
                total = total2;
                total2 = 0;
                //Console.WriteLine(total);

                //For loop 250 ganger
                for (var i = 0; i < range; i++)
                {
                    //Hvis counts[1], counts[2] osv (opp til 250) er større enn 0
                    if (counts[i] > 0)
                    {
                        //gjør int til char og legg inni character
                        var character = (char)i;

                        //Må gjøres om til double
                        var percentage = 100 * (double)counts[i] / total;

                        //Skriver ut bokstav (unicode) + antall av hver bokstav
                        var output = character + " - " + percentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}
