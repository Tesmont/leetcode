namespace LeetCode.P00560SubarraySumEqualsK;

/// <summary>
/// LeetCode 560. Subarray Sum Equals K.
/// https://leetcode.com/problems/subarray-sum-equals-k/
/// </summary>
public sealed class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> prefixSumCounts = new(nums.Length + 1)
        {
            [0] = 1
        };

        int subarrayCount = 0;
        int prefixSum = 0;

        foreach (int num in nums)
        {
            prefixSum += num;
            int targetPrefixSum = prefixSum - k;

            if (prefixSumCounts.TryGetValue(targetPrefixSum, out int count))
            {
                subarrayCount += count;
            }

            prefixSumCounts.TryGetValue(prefixSum, out count);
            prefixSumCounts[prefixSum] = count + 1;
        }

        return subarrayCount;
    }
}
