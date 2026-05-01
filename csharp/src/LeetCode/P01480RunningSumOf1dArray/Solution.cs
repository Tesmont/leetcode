namespace LeetCode.P01480RunningSumOf1dArray;

/// <summary>
/// LeetCode #1480 - Running Sum of 1d Array.
/// Problem: https://leetcode.com/problems/running-sum-of-1d-array/
/// </summary>
public sealed class Solution
{
    public int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        return nums;
    }
}
