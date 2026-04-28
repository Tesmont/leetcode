namespace LeetCode.P00167TwoSumIIInputArrayIsSorted.BinarySearch;

/// <summary>
/// LeetCode #167 - Two Sum II - Input Array Is Sorted.
/// Problem: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
/// </summary>
public sealed class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int complement = target - numbers[i];
            if (TryFind(numbers, i + 1, complement, out int complementIndex))
            {
                return [i + 1, complementIndex + 1];
            }
        }

        throw new InvalidOperationException("No solution found.");
    }

    private static bool TryFind(int[] numbers, int startIndex, int target, out int foundIndex)
    {
        int leftIndex = startIndex;
        int rightExclusiveIndex = numbers.Length;

        while (leftIndex < rightExclusiveIndex)
        {
            int middleIndex = leftIndex + (rightExclusiveIndex - leftIndex) / 2;
            int number = numbers[middleIndex];
            if (number == target)
            {
                foundIndex = middleIndex;
                return true;
            }

            if (number > target)
            {
                rightExclusiveIndex = middleIndex;
            }
            else
            {
                leftIndex = middleIndex + 1;
            }
        }

        foundIndex = 0;
        return false;
    }
}
