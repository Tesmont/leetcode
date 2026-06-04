namespace LeetCode.P02270NumberOfWaysToSplitArray.PrefixSum;

/// <summary>
/// LeetCode 2270. Number of Ways to Split Array.
/// https://leetcode.com/problems/number-of-ways-to-split-array/
/// </summary>
public sealed class Solution
{
    public int WaysToSplitArray(int[] nums)
    {
        long totalSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            totalSum += nums[i];
        }

        int result = 0;
        long leftSum = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            leftSum += nums[i];
            long rightSum = totalSum - leftSum;

            if (leftSum >= rightSum)
            {
                result++;
            }
        }

        return result;
    }
}
