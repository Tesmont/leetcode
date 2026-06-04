namespace LeetCode.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences.Counting;

/// <summary>
/// LeetCode 1941. Check if All Characters Have Equal Number of Occurrences.
/// https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/
/// </summary>
public sealed class Solution
{
    public bool AreOccurrencesEqual(string s)
    {
        Span<short> counts = stackalloc short['z' + 1];
        for (int i = 0; i < s.Length; i++)
        {
            counts[s[i]]++;
        }

        short expectedCount = counts[s[0]];
        for (int i = 1; i < counts.Length; i++)
        {
            if (counts[i] != 0 && counts[i] != expectedCount)
            {
                return false;
            }
        }

        return true;
    }
}
