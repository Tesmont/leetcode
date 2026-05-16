namespace LeetCode.P00451SortCharactersByFrequency;

/// <summary>
/// LeetCode 451. Sort Characters By Frequency.
/// https://leetcode.com/problems/sort-characters-by-frequency/
/// </summary>
public sealed class Solution
{
    public string FrequencySort(string s)
    {
        const int startIndex = '0';
        const int endIndex = 'z';
        Span<int> frequencies = stackalloc int[endIndex + 1];

        for (int i = 0; i < s.Length; i++)
        {
            frequencies[s[i]]++;
        }

        List<char>[] buckets = new List<char>[s.Length + 1];

        for (int i = startIndex; i < frequencies.Length; i++)
        {
            int frequency = frequencies[i];
            if (frequency == 0)
            {
                continue;
            }

            buckets[frequency] ??= [];
            buckets[frequency].Add((char)i);
        }

        char[] result = new char[s.Length];
        int index = 0;

        for (int frequency = buckets.Length - 1; frequency > 0; frequency--)
        {
            if (buckets[frequency] is null)
            {
                continue;
            }

            foreach (char c in buckets[frequency])
            {
                result.AsSpan(index, frequency).Fill(c);
                index += frequency;
            }
        }

        return new string(result);
    }
}
