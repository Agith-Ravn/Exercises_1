using System;
using System.Collections.Generic;

namespace Oppgave10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"Agith", "Ida", "Kayla", "Bob"};
            
            names.Add("Leo");
            names.Remove("Bob");


            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine($"Hello {names[i].ToUpper()}!");
            //}

            var index = names.IndexOf("Agith"); 
            Console.WriteLine($"Fant Agith i Index {index}");
        }
    }
}
