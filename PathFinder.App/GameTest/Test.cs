using BoardChart;
using NUnit.Framework;

namespace GameTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void CanInstantiateBoard()
        {
            Assert.That(new Board(),Is.Not.Null);
        }

    }
}