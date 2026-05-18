namespace LeetCode.P01695MaximumErasureValue;

/// <summary>
/// LeetCode 1695. Maximum Erasure Value.
/// https://leetcode.com/problems/maximum-erasure-value/
/// </summary>
public sealed class Solution
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        const int maxNum = 10_000;
        Span<bool> seen = stackalloc bool[maxNum + 1];
        int leftIndex = 0;
        int windowTotal = 0;
        int maxWindowTotal = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            int rightNum = nums[rightIndex];
            while (seen[rightNum])
            {
                int leftNum = nums[leftIndex];
                windowTotal -= leftNum;
                seen[leftNum] = false;
                leftIndex++;
            }

            windowTotal += rightNum;
            seen[rightNum] = true;
            maxWindowTotal = Math.Max(maxWindowTotal, windowTotal);
        }

        return maxWindowTotal;
    }
}
