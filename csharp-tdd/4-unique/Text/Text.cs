using System;
using System.Collections.Generic;

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
        /// Returns the index of the first non-repeating character in the given string.
        /// </summary>
        /// <remarks>
        /// This method scans the string to count occurrences of each character, then returns
        /// the index of the first character whose count equals one. The method uses a dictionary
        /// to store character counts before performing a linear scan to find the first unique character.
        /// If the string is <c>null</c> or empty, or if all characters repeat, the method returns -1.
        /// </remarks>
        /// <param name="s">The input string to search. If <c>null</c> or empty, returns -1.</param>
        /// <returns>The zero-based index of the first unique character, or -1 if none exists.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
                if (counts[s[i]] == 1)
                    return i;

            return -1;
        }
    }
}
