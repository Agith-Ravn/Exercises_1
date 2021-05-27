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
            var dice = new Dice();
            dice.Roll();
            var number1 = dice.Number;
            dice.Roll();
            var number2 = dice.Number;

            //Anta at number1 og number2 er ikke lik
            Assert.AreNotEqual(number1, number2);
        }
    }
}