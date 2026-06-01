namespace LeetCode.P00020ValidParentheses;

/// <summary>
/// LeetCode #20 - Valid Parentheses.
/// Problem: https://leetcode.com/problems/valid-parentheses/
/// </summary>
public sealed class Solution
{
    public bool IsValid(string s)
    {
        const int asciiLength = 128;
        Span<char> map = stackalloc char[asciiLength];
        map[')'] = '(';
        map[']'] = '[';
        map['}'] = '{';

        Span<char> stack = stackalloc char[s.Length];
        int count = 0;

        foreach (char ch in s)
        {
            char mappedCh = map[ch];

            if (mappedCh == 0)
            {
                stack[count] = ch;
                count++;
                continue;
            }

            count--;
            if (count < 0
                || stack[count] != mappedCh)
            {
                return false;
            }
        }

        return count == 0;
    }
}
