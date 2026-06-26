using System;

namespace Text
{
    /// <summary>
    /// Provides static utility methods for string analysis and manipulation.
    /// </summary>
    /// <remarks>
    /// The <c>Str</c> class contains static methods for performing common string operations.
    /// All methods are static and can be called without creating an instance of the class.
    /// </remarks>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string.
        /// </summary>
        /// <remarks>
        /// In camelCase notation, each word after the first begins with an uppercase letter.
        /// This method counts the total number of words by counting uppercase letters and adding
        /// one for the initial lowercase word. An empty or <c>null</c> string returns zero.
        /// </remarks>
        /// <param name="s">A camelCase string. If <c>null</c> or empty, the method returns zero.</param>
        /// <returns>The number of words in <paramref name="s"/>, or zero for <c>null</c> or empty input.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int count = 1;
            foreach (char c in s)
                if (char.IsUpper(c))
                    count++;

            return count;
        }
    }
}
