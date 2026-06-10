namespace LeetCode.P00946ValidateStackSequences.Stack;

/// <summary>
/// LeetCode 946. Validate Stack Sequences.
/// https://leetcode.com/problems/validate-stack-sequences/
/// </summary>
public sealed class Solution
{
    public bool ValidateStackSequences(int[] pushed, int[] popped)
    {
        Stack<int> pushedStack = new(pushed.Length);
        int poppedIndex = 0;

        foreach(int value in pushed)
        {
            if(value == popped[poppedIndex])
            {
                poppedIndex++;
                continue;
            }

            pushedStack.Push(value);
        }

        while(pushedStack.TryPop(out int value))
        {
            if(value == popped[poppedIndex])
            {
                return false;
            }

            poppedIndex++;
        }
        
        return true;
    }
}
