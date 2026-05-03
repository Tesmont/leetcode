namespace LeetCode.P00283MoveZeroes;

/// <summary>
/// LeetCode 283. Move Zeroes.
/// https://leetcode.com/problems/move-zeroes/
/// </summary>
public sealed class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int leftIndex = 0;
        while (leftIndex < nums.Length)
        {
            if (nums[leftIndex] == 0)
            {
                break;
            }

            leftIndex++;
        }

        int rightIndex = leftIndex + 1;
        while (rightIndex < nums.Length)
        {
            if (nums[rightIndex] != 0)
            {
                nums[leftIndex] = nums[rightIndex];
                nums[rightIndex] = 0;
                leftIndex++;
            }

            rightIndex++;
        }
    }
}
