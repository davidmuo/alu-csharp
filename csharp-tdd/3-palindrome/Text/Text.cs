using System;
using System.Linq;

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
        /// Determines whether the given string is a palindrome.
        /// </summary>
        /// <remarks>
        /// A palindrome is a sequence of characters that reads the same forward and backward.
        /// This method ignores letter case, spaces, and non-alphanumeric characters when
        /// performing the comparison. A <c>null</c> string or a string that becomes empty after
        /// filtering is considered a palindrome.
        /// </remarks>
        /// <param name="s">The input string to evaluate. Non-alphanumeric characters and case are ignored.</param>
        /// <returns><c>true</c> if the cleaned string is a palindrome; <c>false</c> otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return true;

            string cleaned = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            if (cleaned.Length == 0)
                return true;

            string reversed = new string(cleaned.Reverse().ToArray());
            return cleaned == reversed;
        }
    }
}
