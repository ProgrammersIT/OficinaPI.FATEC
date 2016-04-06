using NUnit.Framework;

namespace OficinaPI.FATEC.Tests
{
    [TestFixture]
    public class ExampleTest
    {
        [Test]
        public void FailingTest()
        {
            Assert.Fail("Este é um teste falhando");
        }

        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
