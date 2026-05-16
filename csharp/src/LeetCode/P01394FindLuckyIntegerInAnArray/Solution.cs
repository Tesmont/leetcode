namespace LeetCode.P01394FindLuckyIntegerInAnArray;

/// <summary>
/// LeetCode 1394. Find Lucky Integer in an Array.
/// https://leetcode.com/problems/find-lucky-integer-in-an-array/
/// </summary>
public sealed class Solution
{
    public int FindLucky(int[] arr)
    {
        const int maxValue = 500;
        Span<short> counts = stackalloc short[maxValue + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            counts[arr[i]]++;
        }

        for (int i = counts.Length - 1; i >= 1; i--)
        {
            if (counts[i] == i)
            {
                return i;
            }
        }

        return -1;
    }
}
