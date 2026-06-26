using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Provides static methods for performing basic mathematical operations on integers.
    /// </summary>
    /// <remarks>
    /// The <c>Operations</c> class contains utility methods for working with collections
    /// of integers. All methods are static and can be called without creating an instance.
    /// </remarks>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum integer value found in the given list.
        /// </summary>
        /// <remarks>
        /// This method iterates through the entire list to find the largest integer value.
        /// If the list is <c>null</c> or contains no elements, the method returns zero by convention.
        /// The method does not modify the original list.
        /// </remarks>
        /// <param name="nums">A list of integers to search. May be <c>null</c> or empty, in which case returns zero.</param>
        /// <returns>The largest integer in <paramref name="nums"/>, or zero if the list is <c>null</c> or empty.</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;

            int max = nums[0];
            foreach (int n in nums)
                if (n > max)
                    max = n;

            return max;
        }
    }
}
