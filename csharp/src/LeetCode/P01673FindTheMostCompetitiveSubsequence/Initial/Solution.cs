namespace LeetCode.P01673FindTheMostCompetitiveSubsequence.Initial;

/// <summary>
/// LeetCode 1673. Find the Most Competitive Subsequence.
/// https://leetcode.com/problems/find-the-most-competitive-subsequence/
/// </summary>
public sealed class Solution
{
    public int[] MostCompetitive(int[] nums, int k)
    {
        int[] stack = new int[k];
        int count = 0;
        int remainingRemovals = nums.Length - k;

        foreach (int num in nums)
        {
            while (count > 0 
                && remainingRemovals > 0 
                && stack[count - 1] > num)
            {
                count--;
                remainingRemovals--;
            }

            if (count < k)
            {
                stack[count] = num;
                count++;
            }
            else
            {
                remainingRemovals--;
            }
        }

        return stack;
    }
}
