namespace LeetCode.P02390RemovingStarsFromAString.Initial;

/// <summary>
/// LeetCode 2390. Removing Stars From a String.
/// https://leetcode.com/problems/removing-stars-from-a-string/
/// </summary>
public sealed class Solution
{
    public string RemoveStars(string s)
    {
        const char star = '*';

        Span<char> stack = stackalloc char[s.Length];
        int count = 0;

        foreach (char ch in s)
        {
            if (ch == star)
            {
                count--;
                continue;
            }

            stack[count] = ch;
            count++;
        }

        return new string(stack[..count]);
    }
}
