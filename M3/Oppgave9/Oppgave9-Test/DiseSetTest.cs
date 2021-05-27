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
            //Lager 
            var diceSet = new DiceSet();
            var values = diceSet.GetValues();
            Assert.AreEqual(5, values.Length);
        }
    }
}