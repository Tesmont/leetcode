namespace LeetCode.P00907SumOfSubarrayMinimums.ThreePasses;

/// <summary>
/// LeetCode 907. Sum of Subarray Minimums.
/// https://leetcode.com/problems/sum-of-subarray-minimums/
/// </summary>
public class Solution
{
    public int SumSubarrayMins(int[] arr)
    {
        const long mod = 1_000_000_007;

        int[] prevLess = new int[arr.Length];
        int[] nextLessOrEqual = new int[arr.Length];

        Stack<int> stack = new(arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            while (stack.Count > 0 && arr[stack.Peek()] >= arr[i])
            {
                stack.Pop();
            }

            prevLess[i] = stack.Count == 0 
                ? -1 
                : stack.Peek();
            stack.Push(i);
        }

        stack.Clear();

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && arr[stack.Peek()] > arr[i])
            {
                stack.Pop();
            }

            nextLessOrEqual[i] = stack.Count == 0 
                ? arr.Length 
                : stack.Peek();
            stack.Push(i);
        }

        long result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            long left = i - prevLess[i];
            long right = nextLessOrEqual[i] - i;

            result = (result + arr[i] * left * right) % mod;
        }

        return (int)result;
    }
}
