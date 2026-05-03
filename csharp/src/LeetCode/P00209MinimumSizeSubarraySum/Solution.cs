namespace LeetCode.P00209MinimumSizeSubarraySum;

/// <summary>
/// LeetCode #209 - Minimum Size Subarray Sum.
/// Problem: https://leetcode.com/problems/minimum-size-subarray-sum/
/// </summary>
public sealed class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue;
        int windowTotal = 0;
        int leftIndex = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            windowTotal += nums[rightIndex];

            while(windowTotal >= target)
            {
                minLength = Math.Min(minLength, rightIndex - leftIndex + 1);
                windowTotal -= nums[leftIndex];
                leftIndex++;
            }
        }

        return minLength == int.MaxValue
            ? 0
            : minLength;
    }
}
