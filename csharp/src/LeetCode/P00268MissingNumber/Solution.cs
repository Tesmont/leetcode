namespace LeetCode.P00268MissingNumber;

/// <summary>
/// LeetCode 268. Missing Number.
/// https://leetcode.com/problems/missing-number/
/// </summary>
public sealed class Solution
{
    public int MissingNumber(int[] nums)
    {
        int length = nums.Length;
        int expectedTotal = length * (length + 1) / 2;
        int actualTotal = 0;
        foreach (int num in nums)
        {
            actualTotal += num;
        }

        return expectedTotal - actualTotal;
    }
}
