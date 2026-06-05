namespace LeetCode.P01438LongestContinuousSubarrayWithAbsoluteDiffLessThanOrEqualToLimit.MonotonicQueue;

/// <summary>
/// LeetCode 1438. Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit.
/// https://leetcode.com/problems/longest-continuous-subarray-with-absolute-diff-less-than-or-equal-to-limit/
/// </summary>
public sealed class Solution
{
    public int LongestSubarray(int[] nums, int limit)
    {
        LinkedList<int> maxIndexes = new();
        LinkedList<int> minIndexes = new();
        int maxSubarrayLength = 0;
        int leftIndex = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            while (maxIndexes.Count != 0
                && nums[rightIndex] >= nums[maxIndexes.Last!.Value])
            {
                maxIndexes.RemoveLast();
            }

            while (minIndexes.Count != 0
                && nums[rightIndex] <= nums[minIndexes.Last!.Value])
            {
                minIndexes.RemoveLast();
            }

            maxIndexes.AddLast(rightIndex);
            minIndexes.AddLast(rightIndex);

            while (nums[maxIndexes.First!.Value] - nums[minIndexes.First!.Value] > limit)
            {
                if (maxIndexes.First!.Value == leftIndex)
                {
                    maxIndexes.RemoveFirst();
                }

                if (minIndexes.First!.Value == leftIndex)
                {
                    minIndexes.RemoveFirst();
                }

                leftIndex++;
            }

            maxSubarrayLength = Math.Max(maxSubarrayLength, rightIndex - leftIndex + 1);
        }

        return maxSubarrayLength;
    }
}
