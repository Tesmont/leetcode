namespace LeetCode.P00167TwoSumIIInputArrayIsSorted;

/// <summary>
/// LeetCode #167 - Two Sum II - Input Array Is Sorted.
/// Problem: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
/// </summary>
public sealed class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int leftIndex = 0;
        int rightIndex = numbers.Length - 1;

        while (true)
        {
            int sum = numbers[leftIndex] + numbers[rightIndex];
            if (sum == target)
            {
                return [leftIndex + 1, rightIndex + 1];
            }

            if (sum < target)
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }
    }
}
