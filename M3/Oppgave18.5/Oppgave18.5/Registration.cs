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

        public Registration(string fileLine)
        {
            var part = fileLine.Split(",");
            StartNumber = Convert.ToInt32(part[0]);
            Name = part[1];
            Club = part[2];
            Nationality = part[3];
            Group = part[4];
            Class = part[5];
        }

        //public Registration(int startNumber, string name, string club, string nationality, string @group, string @class)
        //{
        //    StartNumber = startNumber;
        //    Name = name;
        //    Club = club;
        //    Nationality = nationality;
        //    Group = @group;
        //    Class = @class;
        //}
    }
}