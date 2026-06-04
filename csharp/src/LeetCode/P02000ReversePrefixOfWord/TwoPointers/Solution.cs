namespace LeetCode.P02000ReversePrefixOfWord.TwoPointers;

/// <summary>
/// LeetCode 2000. Reverse Prefix of Word.
/// https://leetcode.com/problems/reverse-prefix-of-word/
/// </summary>
public sealed class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        int rightIndex = 0;
        while (rightIndex < word.Length)
        {
            if (word[rightIndex] == ch)
            {
                break;
            }

            rightIndex++;
        }

        if (rightIndex == word.Length)
        {
            return word;
        }

        int leftIndex = 0;
        char[] result = word.ToCharArray();
        while (leftIndex < rightIndex)
        {
            char tmp = result[leftIndex];
            result[leftIndex] = result[rightIndex];
            result[rightIndex] = tmp;

            leftIndex++;
            rightIndex--;
        }

        return new string(result);
    }
}
