namespace LeetCode.P00724FindPivotIndex;

/// <summary>
/// LeetCode #724 - Find Pivot Index.
/// Problem: https://leetcode.com/problems/find-pivot-index/
/// </summary>
public sealed class Solution
{
    public int PivotIndex(int[] nums)
    {
        int leftSum = 0;
        int rightSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            rightSum += nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}
