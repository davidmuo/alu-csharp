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

        [TestCase(TestName = "is a palindrome")]
        public void TestIsPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("racecar"));
        }

        [TestCase(TestName = "level")]
        public void TestLevel()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
        }

        [TestCase(TestName = "mixed case")]
        public void TestMixedCase()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        [TestCase(TestName = "spaces and punctuation")]
        public void TestSpacesAndPunctuation()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [TestCase(TestName = "empty string")]
        public void TestEmptyString()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [TestCase(TestName = "not a palindrome")]
        public void TestNotAPalindrome()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
        }
    }
}
