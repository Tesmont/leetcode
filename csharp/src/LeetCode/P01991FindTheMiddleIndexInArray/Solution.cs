namespace LeetCode.P01991FindTheMiddleIndexInArray;

/// <summary>
/// LeetCode #1991 - Find the Middle Index in Array.
/// Problem: https://leetcode.com/problems/find-the-middle-index-in-array/
/// </summary>
public sealed class Solution
{
    public int FindMiddleIndex(int[] nums)
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
