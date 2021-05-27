using NUnit.Framework;
using Oppgave9;

namespace Oppgave9_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRoll()
        {
            //Lager instance/object av Dice
            var dice = new Dice();

            //Kjører object method
            dice.Roll();

            //Kjører dice.number (tilfeldig tall mellom 1-6)
            var number1 = dice.Number;
            dice.Roll();
            var number2 = dice.Number;

            //Anta at number1 og number2 er ikke lik
            Assert.AreNotEqual(number1, number2);
        }
    }
}