namespace LeetCode.P01063NumberOfValidSubarrays.Initial;

/// <summary>
/// LeetCode 1063. Number of Valid Subarrays.
/// https://leetcode.com/problems/number-of-valid-subarrays/
/// </summary>
public sealed class Solution
{
    public int ValidSubarrays(int[] nums)
    {
        Span<int> stack = stackalloc int[nums.Length];
        int stackCount = 0;
        int subArrayCount = 0;

        foreach (int num in nums)
        {
            while (stackCount > 0 && stack[stackCount - 1] > num)
            {
                stackCount--;
            }

            stack[stackCount] = num;
            stackCount++;

            subArrayCount += stackCount;
        }

        return subArrayCount;
    }
}
