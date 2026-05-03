namespace LeetCode.P01456MaximumNumberOfVowelsInASubstringOfGivenLength;

/// <summary>
/// LeetCode #1456 - Maximum Number of Vowels in a Substring of Given Length.
/// Problem: https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
/// </summary>
public sealed class Solution
{
    static readonly byte[] Vowels;

    static Solution()
    {
        Vowels = new byte['z' + 1];
        Vowels['a'] = 1;
        Vowels['e'] = 1;
        Vowels['i'] = 1;
        Vowels['o'] = 1;
        Vowels['u'] = 1;
    }

    public int MaxVowels(string s, int k)
    {
        if (s.Length < k)
        {
            return 0;
        }

        int windowVowelCount = 0;
        for (int rightIndex = 0; rightIndex < k; rightIndex++)
        {
            windowVowelCount += Vowels[s[rightIndex]];
        }

        int maxWindowVowelsCount = windowVowelCount;
        for (int rightIndex = k; rightIndex < s.Length; rightIndex++)
        {
            windowVowelCount -= Vowels[s[rightIndex - k]];
            windowVowelCount += Vowels[s[rightIndex]];

            maxWindowVowelsCount = Math.Max(maxWindowVowelsCount, windowVowelCount);
        }

        return maxWindowVowelsCount;
    }
}
