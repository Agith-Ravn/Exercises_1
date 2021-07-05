using System;
using System.Collections.Generic;
using System.IO;

namespace Oppgave18._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Regisration>();

            using (var file = new StreamReader("startlist.csv"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var registration = new Regisration(line);
                    list.Add(registration);
                }
            }
        }
    }
}
