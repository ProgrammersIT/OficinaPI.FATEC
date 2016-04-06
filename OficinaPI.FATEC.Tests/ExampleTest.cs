using NUnit.Framework;

namespace OficinaPI.FATEC.Tests
{
    public class ExampleTest
    {
        [Test]
        public void FailingTest()
        {
            Assert.Fail("Failling Test");
        }

        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
