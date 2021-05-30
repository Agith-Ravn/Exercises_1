using System;
using System.Collections.Generic;

namespace Oppgave10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Ida", "Kayla", "Bob", "Agith" };

            names.Add("Leo");
            names.Remove("Bob");


            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }

            var index = names.IndexOf("Agith");
            if (index == -1)
            {
                Console.WriteLine("fant ikke index av Agith");
            }
            else
            {
                Console.WriteLine($"Fant Agith i Index {index}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //----------------------------------------------------------

            var fibonacciNumbers = new List<int> {1, 1};

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
