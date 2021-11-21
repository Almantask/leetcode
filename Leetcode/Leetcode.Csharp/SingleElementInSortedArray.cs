namespace Leetcode.Csharp
{
    /// <summary>
    /// https://leetcode.com/problems/single-element-in-a-sorted-array/submissions/
    /// </summary>
    public class SingleElementInSortedArray
    {
        public static int SolveV1(int[] nums)
        {
            var i = 0;

            try
            {
                // The result always exists.
                while (nums[i] == nums[i + 1])
                {
                    i += 2;
                }
            }
            catch { }

            return nums[i];
        }

        public static int SolveV2(int[] nums)
        {
            var i = 0;

            if (nums.Length == 1) return nums[0];

            while (i != (nums.Length - 1) && nums[i] == nums[i + 1])
            {
                i += 2;
            }

            return nums[i];
        }

        public static int SolveV3(int[] nums)
        {
            // if left and right not equal to mid - return that's the guy
            // if left equal mid - go to right (recursive)
            // if right equal mid - go to left (recursive)
            // if nothing on the right or left - return that's the guy
            var nonDuplicate = FindNonDuplicate(nums, 0, nums.Length - 1);

            return nonDuplicate;

            static int FindNonDuplicate(int[] numbers, int start, int end)
            {
                if (start == end) return numbers[start];

                var mid = (start + end) / 2;
                var isEven = (end - mid) % 2 == 0;
                if (isEven) mid++;

                // A non duplicate shifts all numbers to left or right.
                // If there is an equal to the right - that means we should search there
                // And vice versa

                int nextEnd;
                int nextStart;

                if (numbers[mid] == numbers[mid - 1])
                {
                    // Search in right
                    nextStart = mid + 1;
                    nextEnd = end;
                }
                else
                {
                    // Search in left
                    nextStart = start;
                    nextEnd = mid - 1;
                }

                return FindNonDuplicate(numbers, nextStart, nextEnd);
            }
        }

        public static int SolveV4(int[] nums)
        {
            return FindNonDuplicate(nums.AsSpan(), 0, nums.Length - 1);

            int FindNonDuplicate(Span<int> numbers, int start, int end)
            {
                if (start == end) return numbers[start];

                var mid = (start + end) / 2;
                var isEven = (end - mid) % 2 == 0;
                if (isEven) mid++;

                int nextEnd;
                int nextStart;

                if (numbers[mid] == numbers[mid - 1])
                {
                    PrepareToMoveRight();
                }
                else
                {
                    PrepareToMoveLeft();
                }

                void PrepareToMoveRight()
                {
                    nextStart = mid + 1;
                    nextEnd = end;
                }

                void PrepareToMoveLeft()
                {
                    nextStart = start;
                    nextEnd = mid - 1;
                }

                return FindNonDuplicate(numbers, nextStart, nextEnd);
            }
        }

    }
}