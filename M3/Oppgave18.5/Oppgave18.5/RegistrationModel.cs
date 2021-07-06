using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Oppgave18._5
{
    public class RegistrationModel
    {
        //Lagrer alle registrasjoner i en liste
        public List<Registration> Registrations { get; private set; }
        public List<Club> Clubs { get; private set; }

        public RegistrationModel()
        {
            Registrations = new List<Registration>();
            Clubs = new List<Club>();
        }


        public void HandleLine(string line)
        {
            var registration = new Registration(line);
            Registrations.Add(registration);

            var club = Clubs.FirstOrDefault(c => c.ClubName == registration.Club);
            if (club == null)
            {
                club = new Club((registration.Club));
                Clubs.Add(club);
            }
            club.Add(registration);
        }
    }
}
