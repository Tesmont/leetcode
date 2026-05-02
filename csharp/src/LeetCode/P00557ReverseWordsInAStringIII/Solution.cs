namespace LeetCode.P00557ReverseWordsInAStringIII;

/// <summary>
/// LeetCode #557 - Reverse Words in a String III.
/// Problem: https://leetcode.com/problems/reverse-words-in-a-string-iii/
/// </summary>
public sealed class Solution
{
    public string ReverseWords(string s)
    {
        const char Space = ' ';
        char[] result = s.ToCharArray();
        int previousSpaceIndex = -1;

        for (int i = 0; i <= s.Length; i++)
        {
            if (i == s.Length
                || s[i] == Space)
            {
                int leftIndex = previousSpaceIndex + 1;
                int rightIndex = i - 1;
                previousSpaceIndex = i;

                while (leftIndex < rightIndex)
                {
                    result[leftIndex] = s[rightIndex];
                    result[rightIndex] = s[leftIndex];
                    leftIndex++;
                    rightIndex--;
                }
            }
        }

        return new string(result);
    }
}
