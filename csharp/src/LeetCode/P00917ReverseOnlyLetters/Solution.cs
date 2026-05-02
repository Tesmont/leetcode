namespace LeetCode.P00917ReverseOnlyLetters;

/// <summary>
/// LeetCode #917 - Reverse Only Letters.
/// Problem: https://leetcode.com/problems/reverse-only-letters/
/// </summary>
public sealed class Solution
{
    public string ReverseOnlyLetters(string s)
    {
        int leftIndex = 0;
        int rightIndex = s.Length - 1;
        char[] result = new char[s.Length];

        while (leftIndex <= rightIndex)
        {
            char leftChar = s[leftIndex];
            if (!char.IsAsciiLetter(leftChar))
            {
                result[leftIndex] = leftChar;
                leftIndex++;
                continue;
            }

            char rightChar = s[rightIndex];
            if (!char.IsAsciiLetter(rightChar))
            {
                result[rightIndex] = rightChar;
                rightIndex--;
                continue;
            }

            result[leftIndex] = rightChar;
            result[rightIndex] = leftChar;

            leftIndex++;
            rightIndex--;
        }

        return new string(result);
    }
}
