namespace LeetCode.P00713SubarrayProductLessThanK.BinarySearch;

/// <summary>
/// LeetCode #713 - Subarray Product Less Than K.
/// Problem: https://leetcode.com/problems/subarray-product-less-than-k/
/// </summary>
public sealed class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k <= 1)
        {
            return 0;
        }

        double[] prefixLogSums = new double[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            prefixLogSums[i + 1] = prefixLogSums[i] + Math.Log(nums[i]);
        }

        double logK = Math.Log(k);
        int result = 0;

        for (int rightExclusive = 1; rightExclusive < prefixLogSums.Length; rightExclusive++)
        {
            double target = prefixLogSums[rightExclusive] - logK + double.Epsilon;
            int firstValidStart = FindFirstGreater(prefixLogSums, rightExclusive, target);
            result += rightExclusive - firstValidStart;
        }

        return result;
    }

    private static int FindFirstGreater(double[] prefixLogSums, int exclusiveUpperBound, double target)
    {
        int left = 0;
        int right = exclusiveUpperBound;

        while (left < right)
        {
            int middle = left + ((right - left) / 2);
            if (prefixLogSums[middle] > target)
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        return left;
    }
}
