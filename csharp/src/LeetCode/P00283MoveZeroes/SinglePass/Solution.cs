namespace LeetCode.P00283MoveZeroes.SinglePass;

/// <summary>
/// LeetCode 283. Move Zeroes.
/// https://leetcode.com/problems/move-zeroes/
/// </summary>
public sealed class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int leftIndex = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            if (nums[rightIndex] == 0)
            {
                continue;
            }

            if (leftIndex != rightIndex)
            {
                nums[leftIndex] = nums[rightIndex];
                nums[rightIndex] = 0;
            }

            leftIndex++;
        }
    }
}
