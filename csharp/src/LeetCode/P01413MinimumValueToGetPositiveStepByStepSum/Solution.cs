namespace LeetCode.P01413MinimumValueToGetPositiveStepByStepSum;

/// <summary>
/// LeetCode #1413 - Minimum Value to Get Positive Step by Step Sum.
/// Problem: https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
/// </summary>
public sealed class Solution
{
    public int MinStartValue(int[] nums)
    {
        int sum = 0;
        // Start at zero so minSum also covers the case where every prefix sum is already positive.
        int minSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            minSum = Math.Min(minSum, sum);
        }

        return -minSum + 1;
    }
}
