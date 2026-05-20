namespace LeetCode.P00791CustomSortString;

/// <summary>
/// LeetCode 791. Custom Sort String.
/// https://leetcode.com/problems/custom-sort-string/
/// </summary>
public sealed class Solution
{
    public string CustomSortString(string order, string s)
    {
        const int startIndex = 'a';
        const int lastIndex = 'z';
        Span<int> frequencies = stackalloc int[lastIndex + 1];
        Span<char> result = stackalloc char[s.Length];
        int resultIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            frequencies[s[i]]++;
        }

        for (int i = 0; i < order.Length; i++)
        {
            char current = order[i];
            int frequency = frequencies[current];
            if (frequency == 0)
            {
                continue;
            }

            frequencies[current] = 0;
            result.Slice(resultIndex, frequency).Fill(current);
            resultIndex += frequency;
        }

        for (int i = startIndex; i < frequencies.Length; i++)
        {
            int frequency = frequencies[i];
            if (frequency == 0)
            {
                continue;
            }

            result.Slice(resultIndex, frequency).Fill((char)i);
            resultIndex += frequency;
        }

        return new(result);
    }
}
