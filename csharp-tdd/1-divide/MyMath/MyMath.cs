using System;

namespace MyMath
{
    /// <summary>
    /// Provides static methods for performing matrix operations on integer arrays.
    /// </summary>
    /// <remarks>
    /// The <c>Matrix</c> class contains utility methods for transforming two-dimensional
    /// integer arrays. All methods are static and can be called without creating an instance.
    /// </remarks>
    public class Matrix
    {
        /// <summary>
        /// Divides every element in a two-dimensional integer matrix by the given divisor.
        /// </summary>
        /// <remarks>
        /// This method creates a new matrix with each element equal to the corresponding element
        /// of the input matrix divided by <paramref name="num"/> using integer division.
        /// If <paramref name="matrix"/> is <c>null</c>, the method returns <c>null</c>.
        /// If <paramref name="num"/> is zero, the method prints an error message and returns <c>null</c>.
        /// </remarks>
        /// <param name="matrix">A two-dimensional integer array to divide. If <c>null</c>, the method returns <c>null</c>.</param>
        /// <param name="num">The integer divisor to apply to every element. Must not be zero.</param>
        /// <returns>A new two-dimensional integer array with each element divided, or <c>null</c> on invalid input.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            try
            {
                if (num == 0)
                    throw new DivideByZeroException();

                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                int[,] result = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        result[i, j] = matrix[i, j] / num;

                return result;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
