namespace LeetCode.P02248IntersectionOfMultipleArrays;

/// <summary>
/// LeetCode 2248. Intersection of Multiple Arrays.
/// https://leetcode.com/problems/intersection-of-multiple-arrays/
/// </summary>
public sealed class Solution
{
    public IList<int> Intersection(int[][] nums)
    {
        const int maxValue = 1_000;
        const int seenSize = maxValue + 1;

        Span<short> seen = stackalloc short[seenSize];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                seen[nums[i][j]]++;
            }
        }

        List<int> result = new(nums.Length);
        for (int i = 0; i < seen.Length; i++)
        {
            if (seen[i] == nums.Length)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
