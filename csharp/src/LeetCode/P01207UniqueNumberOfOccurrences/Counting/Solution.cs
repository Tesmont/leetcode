namespace LeetCode.P01207UniqueNumberOfOccurrences.Counting;

/// <summary>
/// LeetCode 1207. Unique Number of Occurrences.
/// https://leetcode.com/problems/unique-number-of-occurrences/
/// </summary>
public sealed class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        const int minValue = -1000;
        const int maxValue = 1000;
        const int offset = -minValue;
        const int maxArrLength = 1000;
        Span<short> frequencies = stackalloc short[maxValue - minValue + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            int value = arr[i] + offset;
            frequencies[value]++;
        }

        Span<bool> seen = stackalloc bool[maxArrLength + 1];
        for (int i = 0; i < frequencies.Length; i++)
        {
            int frequency = frequencies[i];
            if (frequency == 0)
            {
                continue;
            }

            if (seen[frequency])
            {
                return false;
            }

            seen[frequency] = true;
        }

        return true;
    }
}
