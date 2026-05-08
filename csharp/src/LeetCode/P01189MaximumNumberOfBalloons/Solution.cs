namespace LeetCode.P01189MaximumNumberOfBalloons;

/// <summary>
/// LeetCode 1189. Maximum Number of Balloons.
/// https://leetcode.com/problems/maximum-number-of-balloons/
/// </summary>
public sealed class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        const int lastLowercaseLetter = 'z';

        Span<int> availableLetterFrequencies = stackalloc int[lastLowercaseLetter + 1];
        for (int i = 0; i < text.Length; i++)
        {
            availableLetterFrequencies[text[i]]++;
        }

        int maxWordCount;
        maxWordCount = availableLetterFrequencies['b'];
        maxWordCount = Math.Min(maxWordCount, availableLetterFrequencies['a']);
        maxWordCount = Math.Min(maxWordCount, availableLetterFrequencies['l'] / 2);
        maxWordCount = Math.Min(maxWordCount, availableLetterFrequencies['o'] / 2);
        maxWordCount = Math.Min(maxWordCount, availableLetterFrequencies['n']);

        return maxWordCount;
    }
}
