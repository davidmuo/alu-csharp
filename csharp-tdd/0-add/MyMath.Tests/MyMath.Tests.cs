using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_LargerPositiveNumbers_ReturnsSum()
        {
            Assert.AreEqual(10, Operations.Add(4, 6));
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsNegativeSum()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            Assert.AreEqual(1, Operations.Add(3, -2));
        }

        [Test]
        public void Add_WithZero_ReturnsOther()
        {
            Assert.AreEqual(5, Operations.Add(5, 0));
        }

        [Test]
        public void Add_ZeroAndZero_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }
    }
}
