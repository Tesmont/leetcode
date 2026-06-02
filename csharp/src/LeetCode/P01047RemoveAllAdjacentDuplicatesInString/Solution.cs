namespace LeetCode.P01047RemoveAllAdjacentDuplicatesInString;

/// <summary>
/// LeetCode #1047 - Remove All Adjacent Duplicates In String.
/// Problem: https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
/// </summary>
public sealed class Solution
{
    public string RemoveDuplicates(string s)
    {
        Span<char> stack = stackalloc char[s.Length];
        int count = 0;

        foreach (char ch in s)
        {
            if (count > 0
                && stack[count - 1] == ch)
            {
                count--;
                continue;
            }

            stack[count++] = ch;
        }

        return new string(stack[..count]);
    }
}
