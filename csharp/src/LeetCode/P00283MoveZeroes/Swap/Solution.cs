namespace LeetCode.P00283MoveZeroes.Swap;

/// <summary>
/// LeetCode 283. Move Zeroes.
/// https://leetcode.com/problems/move-zeroes/
/// </summary>
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int leftIndex = 0;
        int rightIndex = 0;

        while (rightIndex < nums.Length)
        {
            if (nums[rightIndex] != 0)
            {
                int tmp = nums[leftIndex];
                nums[leftIndex] = nums[rightIndex];
                nums[rightIndex] = tmp;

                leftIndex++;
                rightIndex++;
            }
            else
            {
                rightIndex++;
            }
        }
    }
}
