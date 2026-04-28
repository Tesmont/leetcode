namespace LeetCode.P00643MaximumAverageSubarrayI;

/// <summary>
/// LeetCode #643 - Maximum Average Subarray I.
/// Problem: https://leetcode.com/problems/maximum-average-subarray-i/
/// </summary>
public sealed class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int windowSum = 0;

        for (int index = 0; index < k; index++)
        {
            windowSum += nums[index];
        }

        int maxWindowSum = windowSum;

        for (int rightIndex = k; rightIndex < nums.Length; rightIndex++)
        {
            windowSum += nums[rightIndex];
            windowSum -= nums[rightIndex - k];
            if (windowSum > maxWindowSum)
            {
                maxWindowSum = windowSum;
            }
        }

        return maxWindowSum / (double)k;
    }
}
