namespace LeetCode.P02090KRadiusSubarrayAverages;

/// <summary>
/// LeetCode #2090 - K Radius Subarray Averages.
/// Problem: https://leetcode.com/problems/k-radius-subarray-averages/
/// </summary>
public sealed class Solution
{
    public int[] GetAverages(int[] nums, int k)
    {
        if (k == 0)
        {
            return nums;
        }

        int[] result = new int[nums.Length];
        Array.Fill(result, -1);

        int windowLength = k + k + 1;
        if (nums.Length < windowLength)
        {
            return result;
        }

        long windowTotal = 0;
        for (int i = 0; i < windowLength; i++)
        {
            windowTotal += nums[i];
        }
        result[k] = (int)(windowTotal / windowLength);

        for (int i = k + 1; i < nums.Length - k; i++)
        {
            windowTotal -= nums[i - k - 1];
            windowTotal += nums[i + k];
            result[i] = (int)(windowTotal / windowLength);
        }

        return result;
    }
}
