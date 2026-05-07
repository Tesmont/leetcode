namespace LeetCode.P01248CountNumberOfNiceSubarrays.PrefixSumDictionary;

/// <summary>
/// LeetCode 1248. Count Number of Nice Subarrays.
/// https://leetcode.com/problems/count-number-of-nice-subarrays/
/// </summary>
public sealed class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        Dictionary<int, int> previousOddCountFrequencies = new(nums.Length + 1)
        {
            [0] = 1
        };

        int niceSubarrayCount = 0;
        int currentOddCount = 0;

        foreach (int num in nums)
        {
            currentOddCount += num % 2;
            int requiredPreviousOddCount = currentOddCount - k;

            previousOddCountFrequencies.TryGetValue(requiredPreviousOddCount, out int matchingPreviousOddCountFrequency);
            niceSubarrayCount += matchingPreviousOddCountFrequency;

            previousOddCountFrequencies.TryGetValue(currentOddCount, out int currentOddCountFrequency);
            previousOddCountFrequencies[currentOddCount] = currentOddCountFrequency + 1;
        }

        return niceSubarrayCount;
    }
}
