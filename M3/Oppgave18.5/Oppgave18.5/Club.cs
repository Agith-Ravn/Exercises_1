using System;
using System.Collections.Generic;

namespace Oppgave18._5
{
    public class Club
    {
        public string ClubName { get; set; }
        public List<Registration> Registrations { get; set; }

        public Club(String name)
        {
            ClubName = name;
            Registrations = new List<Registration>();
        }

        public void Add(Registration registration)
        {
            Registrations.Add(registration);
        }
    }
}