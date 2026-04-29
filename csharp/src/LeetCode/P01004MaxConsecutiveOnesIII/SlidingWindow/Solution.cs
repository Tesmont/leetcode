namespace LeetCode.P01004MaxConsecutiveOnesIII.SlidingWindow;

/// <summary>
/// LeetCode #1004 - Max Consecutive Ones III.
/// Problem: https://leetcode.com/problems/max-consecutive-ones-iii/
/// </summary>
public sealed class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int leftIndex = 0;
        int maxWindowLength = 0;
        int zeroCount = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            if (nums[rightIndex] == 0)
            {
                zeroCount++;
            }

            while (zeroCount > k)
            {
                if (nums[leftIndex] == 0)
                {
                    zeroCount--;
                }

                leftIndex++;
            }

            int windowLength = rightIndex - leftIndex + 1;
            if (windowLength > maxWindowLength)
            {
                maxWindowLength = windowLength;
            }
        }

        return maxWindowLength;
    }
}
