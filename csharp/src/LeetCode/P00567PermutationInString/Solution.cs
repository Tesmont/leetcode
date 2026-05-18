namespace LeetCode.P00567PermutationInString;

/// <summary>
/// LeetCode #567 - Permutation in String.
/// Problem: https://leetcode.com/problems/permutation-in-string/
/// </summary>
public sealed class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length)
        {
            return false;
        }

        const int firstIndex = 'a';
        const int lastIndex = 'z';
        Span<int> s1Frequencies = stackalloc int[lastIndex + 1];
        Span<int> windowFrequencies = stackalloc int[lastIndex + 1];

        for (int i = 0; i < s1.Length; i++)
        {
            s1Frequencies[s1[i]]++;
            windowFrequencies[s2[i]]++;
        }
        s1Frequencies = s1Frequencies[firstIndex..];

        if (s1Frequencies.SequenceEqual(windowFrequencies[firstIndex..]))
        {
            return true;
        }

        for (int rightIndex = s1.Length; rightIndex < s2.Length; rightIndex++)
        {
            int leftIndex = rightIndex - s1.Length;

            windowFrequencies[s2[leftIndex]]--;
            windowFrequencies[s2[rightIndex]]++;

            if (s1Frequencies.SequenceEqual(windowFrequencies[firstIndex..]))
            {
                return true;
            }
        }

        return false;
    }
}
