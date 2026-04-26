namespace LeetCode.P00167TwoSumIIInputArrayIsSorted;

/// <summary>
/// LeetCode #167 - Two Sum II - Input Array Is Sorted.
/// Problem: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
/// </summary>
public sealed class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int index1 = 0;
        int index2 = numbers.Length - 1;
        while (true)
        {
            int sum = numbers[index1] + numbers[index2];
            if (sum == target)
            {
                return [++index1, ++index2];
            }

            if (sum < target)
            {
                ++index1;
            }
            else
            {
                --index2;
            }
        }
    }
}
