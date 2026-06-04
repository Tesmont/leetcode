namespace LeetCode.P00844BackspaceStringCompare.TwoPointers;

/// <summary>
/// LeetCode 844. Backspace String Compare.
/// https://leetcode.com/problems/backspace-string-compare/
/// </summary>
public sealed class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        int sIndex = s.Length - 1;
        int tIndex = t.Length - 1;

        while (sIndex >= 0 || tIndex >= 0)
        {
            sIndex = GetPreviousCharIndex(s, sIndex);
            tIndex = GetPreviousCharIndex(t, tIndex);

            if (sIndex < 0 || tIndex < 0)
            {
                return sIndex == tIndex;
            }

            if (s[sIndex] != t[tIndex])
            {
                return false;
            }

            sIndex--;
            tIndex--;
        }

        return true;
    }

    private static int GetPreviousCharIndex(string value, int index)
    {
        const char backspace = '#';
        int backspaces = 0;

        while (index >= 0)
        {
            if (value[index] == backspace)
            {
                backspaces++;
                index--;
                continue;
            }

            if (backspaces == 0)
            {
                return index;
            }

            backspaces--;
            index--;
        }

        return index;
    }
}
