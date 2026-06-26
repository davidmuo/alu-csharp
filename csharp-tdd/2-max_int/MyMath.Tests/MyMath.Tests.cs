using System.Collections.Generic;
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

        [TestCase(TestName = "regular max")]
        public void TestRegularMax()
        {
            Assert.AreEqual(5, Operations.Max(new List<int> { 1, 5, 3, 2 }));
        }

        [TestCase(TestName = "empty list")]
        public void TestEmptyList()
        {
            Assert.AreEqual(0, Operations.Max(new List<int>()));
        }

        [TestCase(TestName = "null list")]
        public void TestNullList()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }

        [TestCase(TestName = "single element")]
        public void TestSingleElement()
        {
            Assert.AreEqual(42, Operations.Max(new List<int> { 42 }));
        }

        [TestCase(TestName = "negative numbers")]
        public void TestNegativeNumbers()
        {
            Assert.AreEqual(-1, Operations.Max(new List<int> { -5, -1, -10 }));
        }

        [TestCase(TestName = "max at end")]
        public void TestMaxAtEnd()
        {
            Assert.AreEqual(10, Operations.Max(new List<int> { 1, 5, 10 }));
        }
    }
}
