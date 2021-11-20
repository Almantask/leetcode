using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Leetcode.Csharp.Tests
{
    public class SingleElementInSortedArrayTests
    {
        [Theory]
        [MemberData(nameof(ExpectedNonDuplicateSolutions))]
        public void Solve_ReturnsNonDuplicate(int[] sortedArray, int onlyNonDuplicate)
        {
            var nonDuplicate = SingleElementInSortedArray.Solve(sortedArray);

            nonDuplicate.Should().Be(onlyNonDuplicate);
        }

        public static IEnumerable<object[]> ExpectedNonDuplicateSolutions
        {
            get
            {
                yield return new object[] { new int[] { 1 }, 1 };
                yield return new object[] { new int[] { 0 }, 0 };
                yield return new object[] { new int[] { -1 }, -1 };
                yield return new object[] { new int[] { 11, 11, 1 }, 1 };
                yield return new object[] { new int[] { 1, 1, 2, 3, 3 }, 2 };
                yield return new object[] { new int[] { 1, 1, 2 }, 2 };
            }
        }
    }
}