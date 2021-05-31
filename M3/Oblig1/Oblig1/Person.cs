using System;

namespace Oblig1
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }

        //Husk til nestegang! Person blir en slags "object datatype!" Når du skal lagre en object, må du lagre det i et object..
        public Person Father { get; set; }
        public Person Mother { get; set; }

        public Person(int Id, string FirstName, string LastName, int BirthYear, int DeathYear, Person Father, Person Mother)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthYear = BirthYear;
            this.DeathYear = DeathYear;
            this.Father = Father;
            this.Mother = Mother;
        }

        //Foreldre
        public Person(int Id, string FirstName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
        }


        //Hvorfor må jeg ha denne?? Alt ser ut til å fungere med denne..
        public Person(){}

        public string GetDescription()
        {   
            //Format: Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)
            string description = "";
            if (FirstName != null) description += $"{FirstName} ";
            if (LastName != null) description += $"{LastName} ";
            if (Id != 0) description += $"(Id={Id}) ";
            if (BirthYear != 0) description += $"Født: {BirthYear} ";
            if (DeathYear != 0) description += $"Død: {DeathYear} ";
            if (Father != null) description += $"Far: {Father.FirstName} (Id={Father.Id}) ";
            if (Mother != null) description += $"Mor: {Mother.FirstName} (Id={Mother.Id}) ";
            return description.TrimEnd();
        }



    }
}