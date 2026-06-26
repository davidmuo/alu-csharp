using System.IO;
using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [TestCase(TestName = "xml documentation")]
        public void TestXMLDocumentation()
        {
            var xmlPath = Path.ChangeExtension(typeof(Str).Assembly.Location, ".xml");
            Assert.IsTrue(File.Exists(xmlPath), "XML documentation not found: " + xmlPath);
        }

        [TestCase(TestName = "first char unique")]
        public void TestFirstCharUnique()
        {
            Assert.AreEqual(0, Str.UniqueChar("leetcode"));
        }

        [TestCase(TestName = "unique in middle")]
        public void TestUniqueInMiddle()
        {
            Assert.AreEqual(2, Str.UniqueChar("loveleetcode"));
        }

        [TestCase(TestName = "no unique char")]
        public void TestNoUniqueChar()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabb"));
        }

        [TestCase(TestName = "single char")]
        public void TestSingleChar()
        {
            Assert.AreEqual(0, Str.UniqueChar("z"));
        }

        [TestCase(TestName = "empty string")]
        public void TestEmptyString()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }
    }
}
