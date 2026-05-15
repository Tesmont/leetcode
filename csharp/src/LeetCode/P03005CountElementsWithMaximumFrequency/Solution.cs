namespace LeetCode.P03005CountElementsWithMaximumFrequency;

/// <summary>
/// LeetCode 3005. Count Elements With Maximum Frequency.
/// https://leetcode.com/problems/count-elements-with-maximum-frequency/
/// </summary>
public sealed class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        const int maxNumsLength = 100;
        Span<byte> counts = stackalloc byte[maxNumsLength + 1];
        int maxFrequencyElements = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            counts[nums[i]]++;
            maxFrequencyElements = Math.Max(maxFrequencyElements, counts[nums[i]]);
        }

        int sum = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] == maxFrequencyElements)
            {
                sum += maxFrequencyElements;
            }
        }

        return sum;
    }
}
