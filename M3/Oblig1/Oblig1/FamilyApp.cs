using System;
using System.Collections.Generic;

namespace Oblig1
{
    public class FamilyApp
    {
        
        //isteden for å skrive alt over^ 
        //List av alle person object
        private readonly List<Person> _people;

        //Gjør om array til liste
        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people); //Hvordan fungerer denne? ser det ut som den får alle verdiene fra array?
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
            else if (command.Contains(" "))
            {
                string[] command2 = command.Split(" ");
                string vis = command2[0];
                int id = Convert.ToInt32(command2[1]);


                //var expectedResponse = $"{Haakon Magnus }{(Id=3) }{Født: 1973 }{Far: Harald }{(Id=6)}\n"
                //                       + "  Barn:\n"
                //                       + $"    {Sverre Magnus }{(Id=1) }{Født: 2005}\n"
                //                       + $"    {Ingrid Alexandra }{(Id=2) }{Født: 2004}\n";

                foreach (var person in _people)
                {
                    if (id == person.Id)
                    {
                        expectedResponse += person.GetDescription() + "\n";

                        if (getChildren(person).Length != 0)
                        {
                            expectedResponse += "  Barn:\n";
                            foreach (var child in getChildren(person))
                            {
                                expectedResponse += $"    {child.FirstName} (Id={child.Id}) Født: {child.BirthYear}\n";
                            }
                           
                        }
                    }
                }

                if (expectedResponse == "") expectedResponse = "Finner ikke person";
            }
            else
            {
                expectedResponse = "Ugydlig kommando.. prøv igjen";
            }

            return expectedResponse;
        }

        public Person[] getChildren(Person parent)
        {
            List<Person> children = new List<Person>();
            foreach (var person in _people)
            {
                if (person.Father == parent || person.Mother == parent)
                {
                    children.Add(person);
                }
            }

            //Liste fungerer ikke.. kun array. hvorfor?
            Person[] children2 = children.ToArray();
            return children2;
        }
    }
}