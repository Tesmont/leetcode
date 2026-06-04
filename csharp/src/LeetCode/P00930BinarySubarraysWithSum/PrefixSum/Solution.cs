namespace LeetCode.P00930BinarySubarraysWithSum.PrefixSum;

/// <summary>
/// LeetCode 930. Binary Subarrays With Sum.
/// https://leetcode.com/problems/binary-subarrays-with-sum/
/// </summary>
public sealed class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        const int maxNumsLenght = 30_000;
        Span<int> prefixSum = stackalloc int[maxNumsLenght + 1];
        prefixSum[0] = 1;
        int total = 0;
        int maxSubarrayCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            total += nums[i];

            if (total >= goal)
            {
                int difference = total - goal;
                maxSubarrayCount += prefixSum[difference];
            }

            prefixSum[total]++;
        }

        return maxSubarrayCount;
    }
}
