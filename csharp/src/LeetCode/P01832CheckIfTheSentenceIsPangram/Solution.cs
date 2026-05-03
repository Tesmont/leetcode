namespace LeetCode.P01832CheckIfTheSentenceIsPangram;

/// <summary>
/// LeetCode #1832 - Check if the Sentence Is Pangram.
/// Problem: https://leetcode.com/problems/check-if-the-sentence-is-pangram/
/// </summary>
public sealed class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        Span<byte> seen = stackalloc byte[128];

        foreach (char letter in sentence)
        {
            seen[letter] = 1;
        }

        int seenLettersCount = 0;
        for (int i = 'a'; i <= 'z'; i++)
        {
            seenLettersCount += seen[i];
        }

        const int alphabetLenght = 'z' - 'a' + 1;

        return seenLettersCount == alphabetLenght;
    }
}
