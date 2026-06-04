namespace LeetCode.P00020ValidParentheses.Stack;

/// <summary>
/// LeetCode 20. Valid Parentheses.
/// https://leetcode.com/problems/valid-parentheses/
/// </summary>
public sealed class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        const int asciiLength = 128;
        Span<char> openingByClosing = stackalloc char[asciiLength];
        openingByClosing[')'] = '(';
        openingByClosing[']'] = '[';
        openingByClosing['}'] = '{';

        Span<char> stack = stackalloc char[s.Length];
        int stackSize = 0;

        foreach (char ch in s)
        {
            char expectedOpening = openingByClosing[ch];

            if (expectedOpening == 0)
            {
                stack[stackSize++] = ch;
                continue;
            }

            if (stackSize == 0
                || stack[--stackSize] != expectedOpening)
            {
                return false;
            }
        }

        return stackSize == 0;
    }
}
