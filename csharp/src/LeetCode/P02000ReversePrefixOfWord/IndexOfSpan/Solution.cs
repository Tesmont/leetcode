namespace LeetCode.P02000ReversePrefixOfWord.IndexOfSpan;

/// <summary>
/// LeetCode #2000 - Reverse Prefix of Word.
/// Problem: https://leetcode.com/problems/reverse-prefix-of-word/
/// </summary>
public sealed class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        int rightIndex = word.IndexOf(ch);
        if (rightIndex < 0)
        {
            return word;
        }

        char[] result = word.ToCharArray();
        result.AsSpan()[..(rightIndex + 1)].Reverse();

        return new string(result);
    }
}
