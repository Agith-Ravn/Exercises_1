using System.Collections.Generic;

namespace Oblig1
{
    public class FamilyApp
    {
        //private readonly Person SverreMagnus;
        //private readonly Person IngridAlexandra;
        //private readonly Person Haakon;
        //private readonly Person MetteMarit;
        //private readonly Person Marius;
        //private readonly Person Harald;
        //private readonly Person Sonja;
        //private readonly Person Olav;

        //public FamilyApp(Person sverreMagnus, Person ingridAlexandra, Person haakon, Person metteMarit, Person marius, Person harald, Person sonja, Person olav)
        //{
        //    this.SverreMagnus = sverreMagnus;
        //    this.IngridAlexandra = ingridAlexandra;
        //    this.Haakon = haakon;
        //    this.MetteMarit = metteMarit;
        //    this.Marius = marius;
        //    this.Harald = harald;
        //    this.Sonja = sonja;
        //    this.Olav = olav;
        

        //isteden for å skrive alt over^ 
        //List av person object
        private readonly List<Person> _people;

        //constructor (array av alle personer)
        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people); //Hvordan fungerer denne?
        }


        public string WelcomeMessage()
        {
            return "Kommandoer: \n \"hjelp\" = viser en hjelpetekst som forklarer alle kommandoene" +
                   "\n \"liste\" = lister alle personer med id, fornavn, fødselsår, dødsår og navn og" +
                   " id på mor og far. \n \"vis <id>\" = viser en bestemt person med mor, far og barn.";
        }

        public string CommandPrompt()
        {
            return "Skriv en kommando: ";
        }

        public object HandleCommand(string command)
        {
            var expectedResponse = "";

            if (command == "hjelp")
            {
                expectedResponse = WelcomeMessage();
            }
            else if (command == "liste")
            {
                foreach (var person in _people)
                {
                    expectedResponse += person.GetDescription() + "\n";
                }
            }

            return expectedResponse;

            //var expectedResponse = $"{Haakon Magnus }{(Id=3) }{Født: 1973 }{Far: Harald }{(Id=6)}\n"
            //                       + "  Barn:\n"
            //                       + $"    {Sverre Magnus }{(Id=1) }{Født: 2005}\n"
            //                       + $"    {Ingrid Alexandra }{(Id=2) }{Født: 2004}\n";
        }
    }
}