namespace LeetCode.P00977SquaresOfASortedArray;

/// <summary>
/// LeetCode #977 - Squares of a Sorted Array.
/// Problem: https://leetcode.com/problems/squares-of-a-sorted-array/
/// </summary>
public sealed class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        nums[0] *= nums[0];
        int firstNum = nums[0];
        for (int lastIndex = nums.Length - 1; lastIndex > 0; lastIndex--)
        {
            nums[lastIndex] *= nums[lastIndex];
            int lastNum = nums[lastIndex];

            if (firstNum > lastNum)
            {
                nums[0] = lastNum;
                nums[lastIndex] = firstNum;
                firstNum = lastNum;
            }
        }

        return nums;
    }
}
