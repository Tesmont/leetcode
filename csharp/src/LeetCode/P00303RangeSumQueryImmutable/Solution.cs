namespace LeetCode.P00303RangeSumQueryImmutable;

/// <summary>
/// LeetCode #303 - Range Sum Query - Immutable.
/// Problem: https://leetcode.com/problems/range-sum-query-immutable/
/// </summary>
public sealed class NumArray
{
    private readonly int[] _prefixSum;

    public NumArray(int[] nums)
    {
        _prefixSum = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            _prefixSum[i + 1] = _prefixSum[i] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        return _prefixSum[right + 1] - _prefixSum[left];
    }
}
