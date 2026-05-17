namespace LeetCode.P02958LengthOfLongestSubarrayWithAtMostKFrequency.StrictWindow;

/// <summary>
/// LeetCode 2958. Length of Longest Subarray With at Most K Frequency.
/// https://leetcode.com/problems/length-of-longest-subarray-with-at-most-k-frequency/
/// </summary>
public sealed class Solution
{
    public int MaxSubarrayLength(int[] nums, int k)
    {
        Dictionary<int, int> frequencies = new(nums.Length);
        int leftIndex = 0;
        int maxSubarrayLength = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            int currentNumber = nums[rightIndex];
            frequencies[currentNumber] = frequencies.GetValueOrDefault(currentNumber, 0) + 1;

            while (frequencies[currentNumber] > k)
            {
                frequencies[nums[leftIndex]]--;
                leftIndex++;
            }

            maxSubarrayLength = Math.Max(maxSubarrayLength, rightIndex - leftIndex + 1);
        }

        return maxSubarrayLength;
    }
}
