namespace LeetCode.P01189MaximumNumberOfBalloons.GenericWord;

/// <summary>
/// LeetCode 1189. Maximum Number of Balloons.
/// https://leetcode.com/problems/maximum-number-of-balloons/
/// </summary>
public sealed class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        const string targetWord = "balloon";
        const int firstLowercaseLetter = 'a';
        const int lastLowercaseLetter = 'z';

        Span<int> requiredLetterFrequencies = stackalloc int[lastLowercaseLetter + 1];
        for (int i = 0; i < targetWord.Length; i++)
        {
            requiredLetterFrequencies[targetWord[i]]++;
        }

        Span<int> availableLetterFrequencies = stackalloc int[lastLowercaseLetter + 1];
        for (int i = 0; i < text.Length; i++)
        {
            availableLetterFrequencies[text[i]]++;
        }

        int maxWordCount = int.MaxValue;
        for (int i = firstLowercaseLetter; i < requiredLetterFrequencies.Length; i++)
        {
            if (requiredLetterFrequencies[i] == 0)
            {
                continue;
            }

            int availableWordCount = availableLetterFrequencies[i] / requiredLetterFrequencies[i];
            maxWordCount = Math.Min(maxWordCount, availableWordCount);
        }

        return maxWordCount;
    }
}
