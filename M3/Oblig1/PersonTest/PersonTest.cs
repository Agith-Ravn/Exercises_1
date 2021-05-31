using NUnit.Framework;
using Oblig1;

namespace PersonTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,

                //Lager en ny object/instance av "Foreldre" (linje 26 Person.cs)
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void MyOwnTest()
        {
            var p = new Person
            {
                Id = 8,
                FirstName = "Agith",
                LastName = "Ravn",
                BirthYear = 1995,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Agith Ravn (Id=8) Født: 1995";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}