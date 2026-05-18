namespace LeetCode.P00205IsomorphicStrings;

/// <summary>
/// LeetCode 205. Isomorphic Strings.
/// https://leetcode.com/problems/isomorphic-strings/
/// </summary>
public sealed class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        const int asciiLenght = 128;
        Span<int> seenS = stackalloc int[asciiLenght];
        Span<int> seenT = stackalloc int[asciiLenght];

        for (int i = 0; i < s.Length; i++)
        {
            char sc = s[i];
            char tc = t[i];

            if (seenS[sc] != seenT[tc])
            {
                return false;
            }

            seenS[sc] = i + 1;
            seenT[tc] = i + 1;
        }

        return true;
    }
}
