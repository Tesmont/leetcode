namespace LeetCode.P00946ValidateStackSequences.Stack;

/// <summary>
/// LeetCode 946. Validate Stack Sequences.
/// https://leetcode.com/problems/validate-stack-sequences/
/// </summary>
public sealed class Solution
{
    public bool ValidateStackSequences(int[] pushed, int[] popped)
    {
        Stack<int> stack = new(pushed.Length);
        int poppedIndex = 0;

        foreach (int value in pushed)
        {
            stack.Push(value);

            while (stack.TryPeek(out int top) 
                && top == popped[poppedIndex])
            {
                stack.Pop();
                poppedIndex++;
            }
        }

        return stack.Count == 0;
    }
}
