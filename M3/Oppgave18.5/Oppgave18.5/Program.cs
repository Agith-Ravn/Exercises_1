using System;
using System.Collections.Generic;
using System.IO;

namespace Oppgave18._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new RegistrationModel();

            using (var file = new StreamReader("startlist.csv"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    model.HandleLine(line);
                }
            }

            Console.Write("Alle klubbene");
            foreach (var club in model.Clubs)
            {
                Console.WriteLine(" " + club.ClubName);
            }
        }
    }
}
