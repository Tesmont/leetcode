namespace LeetCode.P01133LargestUniqueNumber.Counting;

/// <summary>
/// LeetCode 1133. Largest Unique Number.
/// https://leetcode.com/problems/largest-unique-number/
/// </summary>
public sealed class Solution
{
    public int LargestUniqueNumber(int[] nums)
    {
        const int maxNumValue = 1000;
        Span<int> frequencies = stackalloc int[maxNumValue + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            frequencies[nums[i]]++;
        }

        for (int i = frequencies.Length - 1; i >= 0; i--)
        {
            if (frequencies[i] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}
