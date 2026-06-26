using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.AreEqual(2, Str.CamelCase("myVariable"));
        }

        [Test]
        public void CamelCase_FourWords_ReturnsFour()
        {
            Assert.AreEqual(4, Str.CamelCase("saveChangesInAutosave"));
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            Assert.AreEqual(4, Str.CamelCase("getMaxIntegerValue"));
        }
    }
}
