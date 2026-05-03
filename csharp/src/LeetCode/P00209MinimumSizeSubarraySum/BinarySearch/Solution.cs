namespace LeetCode.P00209MinimumSizeSubarraySum.BinarySearch;

/// <summary>
/// LeetCode #209 - Minimum Size Subarray Sum.
/// Problem: https://leetcode.com/problems/minimum-size-subarray-sum/
/// </summary>
public sealed class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int[] prefixSum = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }

        int minLength = int.MaxValue;
        for (int startIndex = 0; startIndex < nums.Length; startIndex++)
        {
            int targetSum = prefixSum[startIndex] + target;
            int endExclusiveIndex = FindFirstGreaterOrEqual(prefixSum, targetSum);
            if (endExclusiveIndex < prefixSum.Length)
            {
                minLength = Math.Min(minLength, endExclusiveIndex - startIndex);
            }
        }

        return minLength == int.MaxValue
            ? 0
            : minLength;
    }

    private static int FindFirstGreaterOrEqual(int[] prefixSum, int target)
    {
        int leftIndex = 0;
        int rightIndex = prefixSum.Length;

        while (leftIndex < rightIndex)
        {
            int midIndex = leftIndex + (rightIndex - leftIndex) / 2;
            if (prefixSum[midIndex] >= target)
            {
                rightIndex = midIndex;
            }
            else
            {
                leftIndex = midIndex + 1;
            }
        }

        return leftIndex;
    }
}
