namespace LeetCode.P02104SumOfSubarrayRanges.Initial;

/// <summary>
/// LeetCode 2104. Sum of Subarray Ranges.
/// https://leetcode.com/problems/sum-of-subarray-ranges/
/// </summary>
public class Solution
{
    public long SubArrayRanges(int[] nums)
    {
        long sumMinimums = SumMinimums(nums);
        long sumMaximums = SumMaximums(nums);

        return sumMaximums - sumMinimums;
    }

    private static long SumMinimums(int[] nums)
    {
        Stack<int> stack = new(nums.Length);
        long result = 0;

        for (int i = 0; i <= nums.Length; i++)
        {
            while (stack.Count > 0 &&
                   (i == nums.Length || nums[i] <= nums[stack.Peek()]))
            {
                int mid = stack.Pop();

                int leftBoundary = stack.Count == 0
                    ? -1
                    : stack.Peek();

                int rightBoundary = i;

                long left = mid - leftBoundary;
                long right = rightBoundary - mid;

                result += nums[mid] * left * right;
            }

            if (i < nums.Length)
            {
                stack.Push(i);
            }
        }

        return result;
    }

    private static long SumMaximums(int[] nums)
    {
        Stack<int> stack = new(nums.Length);
        long result = 0;

        for (int i = 0; i <= nums.Length; i++)
        {
            while (stack.Count > 0 &&
                   (i == nums.Length || nums[i] >= nums[stack.Peek()]))
            {
                int mid = stack.Pop();

                int leftBoundary = stack.Count == 0
                    ? -1
                    : stack.Peek();

                int rightBoundary = i;

                long left = mid - leftBoundary;
                long right = rightBoundary - mid;

                result += nums[mid] * left * right;
            }

            if (i < nums.Length)
            {
                stack.Push(i);
            }
        }

        return result;
    }
}