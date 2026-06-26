using System.Collections.Generic;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_PositiveNumbers_ReturnsMax()
        {
            Assert.AreEqual(5, Operations.Max(new List<int> { 1, 5, 3, 2 }));
        }

        [Test]
        public void Max_NegativeNumbers_ReturnsLeastNegative()
        {
            Assert.AreEqual(-1, Operations.Max(new List<int> { -5, -1, -10 }));
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(new List<int>()));
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }

        [Test]
        public void Max_SingleElement_ReturnsThatElement()
        {
            Assert.AreEqual(42, Operations.Max(new List<int> { 42 }));
        }

        [Test]
        public void Max_MixedNumbers_ReturnsMax()
        {
            Assert.AreEqual(5, Operations.Max(new List<int> { -10, 0, 5, 3, -2 }));
        }
    }
}
