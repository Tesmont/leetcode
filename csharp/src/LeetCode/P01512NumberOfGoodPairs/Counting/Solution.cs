namespace LeetCode.P01512NumberOfGoodPairs.Counting;

/// <summary>
/// LeetCode 1512. Number of Good Pairs.
/// https://leetcode.com/problems/number-of-good-pairs/
/// </summary>
public sealed class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        const int maxValue = 100;
        Span<byte> counts = stackalloc byte[maxValue + 1];
        int goodPairCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            goodPairCount += counts[num];
            counts[num]++;
        }

        return goodPairCount;
    }
}
