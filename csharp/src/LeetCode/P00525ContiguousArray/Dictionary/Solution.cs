namespace LeetCode.P00525ContiguousArray.Dictionary;

/// <summary>
/// LeetCode 525. Contiguous Array.
/// https://leetcode.com/problems/contiguous-array/
/// </summary>
public sealed class Solution
{
    public int FindMaxLength(int[] nums)
    {
        Dictionary<int, int> firstIndexByBalance = new(nums.Length + 1)
        {
            [0] = -1,
        };

        int maxSubarrayLength = 0;
        int balance = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                balance--;
            }
            else
            {
                balance++;
            }

            if (firstIndexByBalance.TryGetValue(balance, out int firstIndex))
            {
                maxSubarrayLength = Math.Max(maxSubarrayLength, i - firstIndex);
            }
            else
            {
                firstIndexByBalance[balance] = i;
            }
        }

        return maxSubarrayLength;
    }
}
