using System;

namespace Leetcode.Csharp.Tests
{
    /// <summary>
    /// https://leetcode.com/problems/single-element-in-a-sorted-array/submissions/
    /// </summary>
    public class SingleElementInSortedArray
    {
        public const int Invalid = -1;
        public static int Solve(int[] numbers)
        {
            var sorted = numbers.OrderBy(n => n).ToArray();
            var i = 0;
            // There can be 1 or more numbers.
            if (numbers.Length == 1) return numbers[0];

            // The result always exists.
            while (i != (numbers.Length - 1) && sorted[i] == sorted[i + 1])
            {
                // 1 1 2 2 3 4 4
                i += 2;
            }

            return sorted[i];
        }
    }
}