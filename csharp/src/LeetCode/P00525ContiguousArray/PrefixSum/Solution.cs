namespace LeetCode.P00525ContiguousArray.PrefixSum;

/// <summary>
/// LeetCode 525. Contiguous Array.
/// https://leetcode.com/problems/contiguous-array/
/// </summary>
public sealed class Solution
{
    public int FindMaxLength(int[] nums)
    {
        int shift = nums.Length + 1;
        int balance = shift;
        int maxLength = 0;

        Span<int> rightIndexByBalance = stackalloc int[2 * nums.Length + 2];
        rightIndexByBalance[balance] = nums.Length;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            balance += nums[i] == 0 ? -1 : 1;

            int rightIndex = rightIndexByBalance[balance];

            if (rightIndex != 0)
            {
                maxLength = Math.Max(maxLength, rightIndex - i);
            }
            else
            {
                rightIndexByBalance[balance] = i;
            }
        }

        return maxLength;
    }
}
