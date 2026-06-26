using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(5, result[0, 0]);
            Assert.AreEqual(10, result[0, 1]);
            Assert.AreEqual(15, result[1, 0]);
            Assert.AreEqual(20, result[1, 1]);
        }

        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            int[,] matrix = { { 10, 20 } };
            Assert.IsNull(Matrix.Divide(matrix, 0));
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            Assert.IsNull(Matrix.Divide(null, 2));
        }

        [Test]
        public void Divide_ByOne_ReturnsSameValues()
        {
            int[,] matrix = { { 7, 14 }, { 21, 28 } };
            int[,] result = Matrix.Divide(matrix, 1);
            Assert.AreEqual(7, result[0, 0]);
            Assert.AreEqual(14, result[0, 1]);
        }

        [Test]
        public void Divide_ByNegative_ReturnsNegatedValues()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, -2);
            Assert.AreEqual(-5, result[0, 0]);
            Assert.AreEqual(-10, result[0, 1]);
        }
    }
}
