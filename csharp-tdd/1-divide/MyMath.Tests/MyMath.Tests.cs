using System.IO;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [TestCase(TestName = "xml documentation")]
        public void TestXMLDocumentation()
        {
            var xmlPath = Path.ChangeExtension(typeof(Matrix).Assembly.Location, ".xml");
            Assert.IsTrue(File.Exists(xmlPath), "XML documentation not found: " + xmlPath);
        }

        [TestCase(TestName = "divide by 2")]
        public void TestDivideByTwo()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(5, result[0, 0]);
            Assert.AreEqual(10, result[0, 1]);
            Assert.AreEqual(15, result[1, 0]);
            Assert.AreEqual(20, result[1, 1]);
        }

        [TestCase(TestName = "divide by 0")]
        public void TestDivideByZero()
        {
            int[,] matrix = { { 10, 20 } };
            Assert.IsNull(Matrix.Divide(matrix, 0));
        }

        [TestCase(TestName = "null matrix")]
        public void TestNullMatrix()
        {
            Assert.IsNull(Matrix.Divide(null, 2));
        }

        [TestCase(TestName = "divide by 1")]
        public void TestDivideByOne()
        {
            int[,] matrix = { { 7, 14 }, { 21, 28 } };
            int[,] result = Matrix.Divide(matrix, 1);
            Assert.AreEqual(7, result[0, 0]);
            Assert.AreEqual(14, result[0, 1]);
        }

        [TestCase(TestName = "divide by negative")]
        public void TestDivideByNegative()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, -2);
            Assert.AreEqual(-5, result[0, 0]);
            Assert.AreEqual(-10, result[0, 1]);
        }
    }
}
