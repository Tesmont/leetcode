namespace LeetCode.P01544MakeTheStringGreat.Stack;

/// <summary>
/// LeetCode 1544. Make The String Great.
/// https://leetcode.com/problems/make-the-string-great/
/// </summary>
public sealed class Solution
{
    public string MakeGood(string s)
    {
        const int difference = 'a' - 'A';
        Span<char> stack = stackalloc char[s.Length];
        int stackCount = 0;

        foreach (char ch in s)
        {
            if (stackCount > 0)
            {
                char lastCh = stack[stackCount - 1];
                if (Math.Abs(lastCh - ch) == difference)
                {
                    stackCount--;
                    continue;
                }
            }

            stack[stackCount] = ch;
            stackCount++;
        }

        return new string(stack[..stackCount]);
    }
}
