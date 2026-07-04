namespace LeetCode.P01306JumpGameIII.Initial;

/// <summary>
/// LeetCode 1306. Jump Game III.
/// https://leetcode.com/problems/jump-game-iii/
/// </summary>
public sealed class Solution
{
    public bool CanReach(int[] arr, int start)
    {
        if (arr[start] == 0)
        {
            return true;
        }

        const int maxArrayLength = 50_001;

        Span<bool> seen = stackalloc bool[maxArrayLength];
        seen[start] = true;

        Span<int> stack = stackalloc int[maxArrayLength];
        stack[0] = start;
        int stackCount = 1;

        while (stackCount > 0)
        {
            stackCount--;
            int arrayIndex = stack[stackCount];
            int jump = arr[arrayIndex];

            int forwardArrayIndex = arrayIndex + jump;
            if (forwardArrayIndex < arr.Length && !seen[forwardArrayIndex])
            {
                if (arr[forwardArrayIndex] == 0)
                {
                    return true;
                }

                seen[forwardArrayIndex] = true;
                stack[stackCount] = forwardArrayIndex;
                stackCount++;
            }

            int backwardArrayIndex = arrayIndex - jump;
            if (backwardArrayIndex >= 0 && !seen[backwardArrayIndex])
            {
                if (arr[backwardArrayIndex] == 0)
                {
                    return true;
                }

                seen[backwardArrayIndex] = true;
                stack[stackCount] = backwardArrayIndex;
                stackCount++;
            }
        }

        return false;
    }
}
