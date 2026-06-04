namespace LeetCode.P02958LengthOfLongestSubarrayWithAtMostKFrequency.SlidingWindow;

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
        int overLimitCount = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            int currentNumber = nums[rightIndex];
            int currentFrequency = frequencies.GetValueOrDefault(currentNumber, 0) + 1;
            frequencies[currentNumber] = currentFrequency;

            if (currentFrequency == k + 1)
            {
                overLimitCount++;
            }

            if (overLimitCount > 0)
            {
                int leftNumber = nums[leftIndex];
                leftIndex++;

                int leftFrequency = frequencies[leftNumber] - 1;
                frequencies[leftNumber] = leftFrequency;

                if (leftFrequency == k)
                {
                    overLimitCount--;
                }
            }
        }

        return nums.Length - leftIndex;
    }
}
