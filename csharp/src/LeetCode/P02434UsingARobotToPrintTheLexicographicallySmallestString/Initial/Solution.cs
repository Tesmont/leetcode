namespace LeetCode.P02434UsingARobotToPrintTheLexicographicallySmallestString.Initial;

/// <summary>
/// LeetCode 2434. Using a Robot to Print the Lexicographically Smallest String.
/// https://leetcode.com/problems/using-a-robot-to-print-the-lexicographically-smallest-string/
/// </summary>
public sealed class Solution
{
    public string RobotWithString(string s)
    {
        Span<char> minRight = stackalloc char[s.Length + 1];
        minRight[^1] = char.MaxValue;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            minRight[i] = s[i] < minRight[i + 1]
                ? s[i]
                : minRight[i + 1];
        }

        Stack<char> stack = new(s.Length);
        char[] result = new char[s.Length];
        int resultIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            stack.Push(s[i]);

            while (stack.Count > 0 && stack.Peek() <= minRight[i + 1])
            {
                result[resultIndex++] = stack.Pop();
            }
        }

        return new string(result);
    }
}
