namespace LeetCode.P00844BackspaceStringCompare.Stack;

/// <summary>
/// LeetCode 844. Backspace String Compare.
/// https://leetcode.com/problems/backspace-string-compare/
/// </summary>
public sealed class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        Span<char> sStack = stackalloc char[s.Length];
        Span<char> tStack = stackalloc char[t.Length];

        ApplyBackspaces(s, ref sStack);
        ApplyBackspaces(t, ref tStack);

        return sStack.SequenceEqual(tStack);
    }

    private static void ApplyBackspaces(string value, ref Span<char> stack)
    {
        const char backspace = '#';
        int count = 0;

        foreach (char ch in value)
        {
            if (ch == backspace)
            {
                if (count > 0)
                {
                    count--;
                }

                continue;
            }

            stack[count] = ch;
            count++;
        }

        stack = stack[..count];
    }
}
