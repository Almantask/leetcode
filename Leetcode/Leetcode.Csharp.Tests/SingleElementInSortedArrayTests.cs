using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Leetcode.Csharp.Tests
{
    public class SingleElementInSortedArrayTests
    {
        [Theory]
        [MemberData(nameof(ExpectedNonDuplicateSolutions))]
        public void SolveV1_ReturnsNonDuplicate(int[] sortedArray, int onlyNonDuplicate)
        {
            var nonDuplicate = SingleElementInSortedArray.SolveV1(sortedArray);

            nonDuplicate.Should().Be(onlyNonDuplicate);
        }

        [Theory]
        [MemberData(nameof(ExpectedNonDuplicateSolutions))]
        public void SolveV2_ReturnsNonDuplicate(int[] sortedArray, int onlyNonDuplicate)
        {
            var nonDuplicate = SingleElementInSortedArray.SolveV2(sortedArray);

            nonDuplicate.Should().Be(onlyNonDuplicate);
        }

        [Theory]
        [MemberData(nameof(ExpectedNonDuplicateSolutions))]
        public void SolveV3_ReturnsNonDuplicate(int[] sortedArray, int onlyNonDuplicate)
        {
            var nonDuplicate = SingleElementInSortedArray.SolveV3(sortedArray);

            nonDuplicate.Should().Be(onlyNonDuplicate);
        }

        [Theory]
        [MemberData(nameof(ExpectedNonDuplicateSolutions))]
        public void SolveV4_ReturnsNonDuplicate(int[] sortedArray, int onlyNonDuplicate)
        {
            var nonDuplicate = SingleElementInSortedArray.SolveV4(sortedArray);

            nonDuplicate.Should().Be(onlyNonDuplicate);
        }

        public static IEnumerable<object[]> ExpectedNonDuplicateSolutions
        {
            get
            {
                yield return new object[] { new int[] { 0 }, 0 };
                yield return new object[] { new int[] { -1 }, -1 };
                yield return new object[] { new int[] { 1, 11, 11 }, 1 };
                yield return new object[] { new int[] { 1, 1, 2, 3, 3 }, 2 };
                yield return new object[] { new int[] { 1, 2, 2, 3, 3 }, 1 };
                yield return new object[] { new int[] { 1, 1, 2, 2, 3 }, 3 };
                yield return new object[] { new int[] { 1, 1, 2, 3, 3, 5, 5 }, 2 };
                yield return new object[] { new int[] { 1, 1, 2, 2, 3, 5, 5 }, 3 };
                yield return new object[] { new int[] { 1, 1, 2 }, 2 };
                yield return new object[] { new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }, 2 };
                yield return new object[] { new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 8, 9, 9 }, 8 };
            }
        }
    }
}