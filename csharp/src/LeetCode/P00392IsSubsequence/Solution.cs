namespace LeetCode.P00392IsSubsequence;

/// <summary>
/// LeetCode #392 - Is Subsequence.
/// Problem: https://leetcode.com/problems/is-subsequence/
/// </summary>
public sealed class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int subsequenceIndex = 0;
        int textIndex = 0;

        while (subsequenceIndex < s.Length)
        {
            if (textIndex == t.Length)
            {
                return false;
            }

            if (s[subsequenceIndex] == t[textIndex])
            {
                subsequenceIndex++;
            }

            textIndex++;
        }

        return true;
    }
}
