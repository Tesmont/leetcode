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
            int difference = target - numbers[i];
            if (TryFind(numbers, i + 1, difference, out int differenceIndex))
            {
                return [i + 1, differenceIndex + 1];
            }
        }

        throw new InvalidOperationException("No solution found.");
    }

    private static bool TryFind(int[] numbers, int startIndex, int value, out int valueIndex)
    {
        int endIndex = numbers.Length;

        while (startIndex < endIndex)
        {
            valueIndex = startIndex + (endIndex - startIndex) / 2;


            int number = numbers[valueIndex];
            if (number == value)
            {
                return true;
            }

            if (number > value)
            {
                endIndex = valueIndex;
            }
            else
            {
                startIndex = valueIndex + 1;
            }
        }

        valueIndex = 0;
        return false;
    }
}
