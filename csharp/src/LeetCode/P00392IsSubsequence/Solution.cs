namespace LeetCode.P00392IsSubsequence;

/// <summary>
/// LeetCode #392 - Is Subsequence.
/// Problem: https://leetcode.com/problems/is-subsequence/
/// </summary>
public sealed class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int sIndex = 0;
        int tIndex = 0;

        while (sIndex < s.Length)
        {
            if (tIndex == t.Length)
            {
                return false;
            }

            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }

            tIndex++;
        }

        return true;
    }
}
