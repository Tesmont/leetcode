namespace LeetCode.P02342MaxSumOfAPairWithEqualSumOfDigits;

/// <summary>
/// LeetCode 2342. Max Sum of a Pair With Equal Sum of Digits.
/// https://leetcode.com/problems/max-sum-of-a-pair-with-equal-sum-of-digits/
/// </summary>
public sealed class Solution
{
    public int MaximumSum(int[] nums)
    {
        Dictionary<int, int> counts = new(nums.Length);
        int maxSum = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int digitSum = 0;
            while (num != 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            if (counts.TryGetValue(digitSum, out int firstIndex))
            {
                int sum = nums[firstIndex] + nums[i];
                maxSum = Math.Max(maxSum, sum);
                if (nums[firstIndex] < nums[i])
                {
                    counts[digitSum] = i;
                }
            }
            else
            {
                counts[digitSum] = i;
            }
        }


        return maxSum;
    }
}
