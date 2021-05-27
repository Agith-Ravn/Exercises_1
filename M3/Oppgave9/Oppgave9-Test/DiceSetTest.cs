using NUnit.Framework;
using Oppgave9;

namespace Oppgave9_Test
{
    public class DiseSetTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetValues()
        {
            var diceSet = new DiceSet();
            var values = diceSet.GetValues();
            Assert.AreEqual(5, values.Length);
        }

        [Test]
        public void TestPointsAsOnePair()
        {
            var diceSet = new DiceSet();
            var values = diceSet.GetValues();
            Assert.AreEqual(5, values.Length);
        }
    }
}