using System;

namespace MyMath
{
    /// <summary>
    /// Provides static methods for performing basic mathematical operations on integers.
    /// </summary>
    /// <remarks>
    /// The <c>Operations</c> class contains utility methods for fundamental arithmetic.
    /// All methods are static and can be called without creating an instance of the class.
    /// </remarks>
    public class Operations
    {
        /// <summary>
        /// Adds two integer values together and returns the sum.
        /// </summary>
        /// <remarks>
        /// This method performs standard 32-bit integer addition. If the result overflows
        /// the range of <see cref="int"/>, the behavior is undefined without checked context.
        /// </remarks>
        /// <param name="a">The first integer operand. Can be any valid 32-bit integer.</param>
        /// <param name="b">The second integer operand. Can be any valid 32-bit integer.</param>
        /// <returns>An integer equal to the arithmetic sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
