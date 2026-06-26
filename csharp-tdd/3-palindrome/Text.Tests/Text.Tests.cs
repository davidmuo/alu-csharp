using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_SimpleWord_ReturnsTrue()
        {
            Assert.AreEqual(true, Str.IsPalindrome("level"));
        }

        [Test]
        public void IsPalindrome_CaseInsensitive_ReturnsTrue()
        {
            Assert.AreEqual(true, Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void IsPalindrome_WithSpacesAndPunctuation_ReturnsTrue()
        {
            Assert.AreEqual(true, Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.AreEqual(true, Str.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            Assert.AreEqual(true, Str.IsPalindrome(null));
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.AreEqual(false, Str.IsPalindrome("hello"));
        }

        [Test]
        public void IsPalindrome_SingleChar_ReturnsTrue()
        {
            Assert.AreEqual(true, Str.IsPalindrome("a"));
        }
    }
}
