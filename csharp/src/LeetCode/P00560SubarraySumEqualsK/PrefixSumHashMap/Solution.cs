namespace LeetCode.P00560SubarraySumEqualsK.PrefixSumHashMap;

/// <summary>
/// LeetCode 560. Subarray Sum Equals K.
/// https://leetcode.com/problems/subarray-sum-equals-k/
/// </summary>
public sealed class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> previousPrefixSumCounts = new(nums.Length + 1)
        {
            [0] = 1
        };

        int matchingSubarrayCount = 0;
        int currentPrefixSum = 0;

        foreach (int num in nums)
        {
            currentPrefixSum += num;
            int requiredPreviousPrefixSum = currentPrefixSum - k;

            previousPrefixSumCounts.TryGetValue(requiredPreviousPrefixSum, out int matchingPreviousPrefixSumCount);
            matchingSubarrayCount += matchingPreviousPrefixSumCount;

            previousPrefixSumCounts.TryGetValue(currentPrefixSum, out int currentPrefixSumCount);
            previousPrefixSumCounts[currentPrefixSum] = currentPrefixSumCount + 1;
        }

        return matchingSubarrayCount;
    }
}
