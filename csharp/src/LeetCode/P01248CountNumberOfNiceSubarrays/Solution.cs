namespace LeetCode.P01248CountNumberOfNiceSubarrays;

/// <summary>
/// LeetCode 1248. Count Number of Nice Subarrays.
/// https://leetcode.com/problems/count-number-of-nice-subarrays/
/// </summary>
public sealed class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int result = 0;
        int leftIndex = 0;
        int windowCounter = 0;

        for (int rightIndex = 0; rightIndex < nums.Length; rightIndex++)
        {
            if (nums[rightIndex] % 2 != 0)
            {
                windowCounter++;
            }

            if (windowCounter < k)
            {
                continue;
            }

            while (windowCounter > k)
            {
                if (nums[leftIndex] % 2 != 0)
                {
                    windowCounter--;
                }

                leftIndex++;
            }

            result += rightIndex - leftIndex + 1;
        }

        return result;
    }
}
