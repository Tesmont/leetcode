namespace LeetCode.P01657DetermineIfTwoStringsAreClose.Counting;

/// <summary>
/// LeetCode 1657. Determine if Two Strings Are Close.
/// https://leetcode.com/problems/determine-if-two-strings-are-close/
/// </summary>
public sealed class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        const int startIndex = 'a';
        const int endIndex = 'z';
        Span<int> frequencies1 = stackalloc int[endIndex + 1];
        Span<int> frequencies2 = stackalloc int[endIndex + 1];
        for (int i = 0; i < word1.Length; i++)
        {
            frequencies1[word1[i]]++;
            frequencies2[word2[i]]++;
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            int frequency1 = frequencies1[i];
            int frequency2 = frequencies2[i];
            bool appearsInWord1 = frequency1 != 0;
            bool appearsInWord2 = frequency2 != 0;

            if (appearsInWord1 != appearsInWord2)
            {
                return false;
            }

            bool hasMatchingFrequency = false;
            for (int j = startIndex; j <= endIndex; j++)
            {
                if (frequencies2[j] == frequency1)
                {
                    frequencies2[j] = -1;
                    hasMatchingFrequency = true;
                    break;
                }
            }

            if (!hasMatchingFrequency)
            {
                return false;
            }
        }

        return true;
    }
}
