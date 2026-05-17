namespace LeetCode.P00217ContainsDuplicate;

/// <summary>
/// LeetCode #217 - Contains Duplicate.
/// Problem: https://leetcode.com/problems/contains-duplicate/
/// </summary>
public sealed class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            if (!seen.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}
