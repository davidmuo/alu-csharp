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

        [TestCase(TestName = "multiple words")]
        public void TestMultipleWords()
        {
            Assert.AreEqual(4, Str.CamelCase("saveChangesInAutosave"));
        }

        [TestCase(TestName = "single word")]
        public void TestSingleWord()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [TestCase(TestName = "two words")]
        public void TestTwoWords()
        {
            Assert.AreEqual(2, Str.CamelCase("myVariable"));
        }

        [TestCase(TestName = "empty string")]
        public void TestEmptyString()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [TestCase(TestName = "four words")]
        public void TestFourWords()
        {
            Assert.AreEqual(4, Str.CamelCase("getMaxIntegerValue"));
        }
    }
}
