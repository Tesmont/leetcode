namespace LeetCode.P00001TwoSum;

/// <summary>
/// LeetCode #1 - Two Sum.
/// Problem: https://leetcode.com/problems/two-sum/
/// </summary>

public sealed class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indexByNumber = new(nums.Length)
        {
            [nums[0]] = 0
        };

        for (int i = 1; i < nums.Length; i++)
        {
            int number = nums[i];
            int complement = target - number;
            if (indexByNumber.TryGetValue(complement, out int complementIndex))
            {
                return [complementIndex, i];
            }

            indexByNumber[number] = i;
        }

        throw new InvalidOperationException("No solution found.");
    }
}
