using System;
using System.Text.RegularExpressions;

namespace Oppgave18._5
{
    public class Registration
    {
        public int StartNumber { get; set; }
        public string Name { get; set; }
        public string Club { get; set; }
        public string Nationality { get; set; }
        public string Group { get; set; }
        public string Class { get; set; }

        //Legge til fra csv fil
        public Registration(string fileLine)
        {
            var part = fileLine.Split(",");
            StartNumber = Convert.ToInt32("0" + part[0].Trim('"'));
            Name = part[1].Trim('"');
            Club = part[2].Trim('"');
            Nationality = part[3].Trim('"');
            Group = part[4].Trim('"');
            Class = part[5].Trim('"');
        }

        public Registration(int startNumber, string name, string club, string nationality, string @group, string @class)
        {
            StartNumber = startNumber;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = @group;
            Class = @class;
        }
    }
}