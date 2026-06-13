namespace LeetCode.P01063NumberOfValidSubarrays.Initial;

/// <summary>
/// LeetCode 1063. Number of Valid Subarrays.
/// https://leetcode.com/problems/number-of-valid-subarrays/
/// </summary>
public sealed class Solution
{
    public int ValidSubarrays(int[] nums)
    {
        int stackCount = 0;
        int validSubarrayCount = 0;

        foreach (int num in nums)
        {
            while (stackCount > 0 && nums[stackCount - 1] > num)
            {
                stackCount--;
            }

            nums[stackCount] = num;
            stackCount++;

            validSubarrayCount += stackCount;
        }

        return validSubarrayCount;
    }
}
