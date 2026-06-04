namespace LeetCode.P00071SimplifyPath.Stack;

/// <summary>
/// LeetCode 71. Simplify Path.
/// https://leetcode.com/problems/simplify-path/
/// </summary>
public sealed class Solution
{
    public string SimplifyPath(string path)
    {
        Stack<string> stack = new();
        string[] segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

        foreach (string segment in segments)
        {
            if (segment == ".")
            {
                continue;
            }

            if (segment == "..")
            {
                stack.TryPop(out _);
                continue;
            }

            stack.Push(segment);
        }

        return "/" + string.Join('/', stack.Reverse());
    }
}
