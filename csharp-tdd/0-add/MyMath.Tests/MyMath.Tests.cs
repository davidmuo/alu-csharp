using System.IO;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [TestCase(TestName = "xml documentation")]
        public void TestXMLDocumentation()
        {
            var xmlPath = Path.ChangeExtension(typeof(Operations).Assembly.Location, ".xml");
            Assert.IsTrue(File.Exists(xmlPath), "XML documentation not found: " + xmlPath);
        }

        [TestCase(TestName = "regular addition")]
        public void TestRegularAddition()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [TestCase(TestName = "positive integers")]
        public void TestPositiveIntegers()
        {
            Assert.AreEqual(10, Operations.Add(4, 6));
        }

        [TestCase(TestName = "negative integers")]
        public void TestNegativeIntegers()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [TestCase(TestName = "positive + negative")]
        public void TestPositiveAndNegative()
        {
            Assert.AreEqual(1, Operations.Add(3, -2));
        }

        [TestCase(TestName = "Add zero")]
        public void TestAddZero()
        {
            Assert.AreEqual(5, Operations.Add(5, 0));
        }

        [TestCase(TestName = "0 + 0")]
        public void TestZeroPlusZero()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }
    }
}
