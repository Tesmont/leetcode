namespace LeetCode.P01248CountNumberOfNiceSubarrays.PrefixSum;

/// <summary>
/// LeetCode 1248. Count Number of Nice Subarrays.
/// https://leetcode.com/problems/count-number-of-nice-subarrays/
/// </summary>
public sealed class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        const int maxNumsLength = 50_000;
        const int oddCountFrequencySize = maxNumsLength + 1;

        Span<int> oddCountFrequencies = stackalloc int[oddCountFrequencySize];
        oddCountFrequencies[0] = 1;

        int niceSubarrayCount = 0;
        int currentOddCount = 0;

        foreach (int num in nums)
        {
            currentOddCount += num % 2;

            if (currentOddCount >= k)
            {
                int requiredPreviousOddCount = currentOddCount - k;
                niceSubarrayCount += oddCountFrequencies[requiredPreviousOddCount];
            }

            oddCountFrequencies[currentOddCount]++;
        }

        return niceSubarrayCount;
    }
}
