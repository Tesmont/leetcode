namespace LeetCode.P00907SumOfSubarrayMinimums.OnePass;

/// <summary>
/// LeetCode 907. Sum of Subarray Minimums.
/// https://leetcode.com/problems/sum-of-subarray-minimums/
/// </summary>
public class Solution
{
    public int SumSubarrayMins(int[] arr)
    {
        const long mod = 1_000_000_007;
        Span<int> stack = stackalloc int[arr.Length];
        int stackCount = 0;
        long result = 0;

        for (int i = 0; i <= arr.Length; i++)
        {
            int current = i == arr.Length
                ? int.MinValue
                : arr[i];

            while (stackCount > 0 
                && arr[stack[stackCount - 1]] >= current)
            {
                stackCount--;
                int index = stack[stackCount];
                int previousLessIndex = stackCount == 0
                    ? -1
                    : stack[stackCount - 1];
                long left = index - previousLessIndex;
                long right = i - index;

                result = (result + arr[index] * left * right) % mod;
            }

            if (i < arr.Length)
            {
                stack[stackCount] = i;
                stackCount++;
            }
        }

        return (int)result;
    }
}
