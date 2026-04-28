namespace LeetCode.P00713SubarrayProductLessThanK;

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

        int result = 0;
        int leftIndex = 0;
        int product = 1;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            product *= nums[rightIndex];
            while (product >= k)
            {
                product /= nums[leftIndex];
                leftIndex++;
            }

            int windowLength = rightIndex - leftIndex + 1;
            result += windowLength;
        }

        return result;
    }
}
