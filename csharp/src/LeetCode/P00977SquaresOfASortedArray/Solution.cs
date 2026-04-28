namespace LeetCode.P00977SquaresOfASortedArray;

/// <summary>
/// LeetCode #977 - Squares of a Sorted Array.
/// Problem: https://leetcode.com/problems/squares-of-a-sorted-array/
/// </summary>
public sealed class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int[] result = new int[nums.Length];
        int writeIndex = nums.Length - 1;

        int leftIndex = 0;
        int rightIndex = writeIndex;

        while (writeIndex >= 0)
        {
            int leftSquare = nums[leftIndex] * nums[leftIndex];
            int rightSquare = nums[rightIndex] * nums[rightIndex];

            if (leftSquare > rightSquare)
            {
                result[writeIndex] = leftSquare;
                leftIndex++;
            }
            else
            {
                result[writeIndex] = rightSquare;
                rightIndex--;
            }

            writeIndex--;
        }

        return result;
    }
}
