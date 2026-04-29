namespace LeetCode.P01004MaxConsecutiveOnesIII;

/// <summary>
/// LeetCode #1004 - Max Consecutive Ones III.
/// Problem: https://leetcode.com/problems/max-consecutive-ones-iii/
/// </summary>
public sealed class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int leftIndex = 0;
        int rightIndex = 0;

        for (; rightIndex < nums.Length; rightIndex++)
        {
            // if (nums[rightIndex] == 0)
            // {
            //    k--;
            // }
            k -= 1 - nums[rightIndex];

            if (k < 0)
            {
                // if (nums[leftIndex] == 0)
                // {
                //    k++;
                // }
                k += 1 - nums[leftIndex];
                leftIndex++;
            }
        }

        int maxWindowLength = rightIndex - leftIndex;

        return maxWindowLength;
    }
}
