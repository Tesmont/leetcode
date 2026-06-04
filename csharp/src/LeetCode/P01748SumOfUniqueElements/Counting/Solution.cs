namespace LeetCode.P01748SumOfUniqueElements.Counting;

/// <summary>
/// LeetCode 1748. Sum of Unique Elements.
/// https://leetcode.com/problems/sum-of-unique-elements/
/// </summary>
public sealed class Solution
{
    public int SumOfUnique(int[] nums)
    {
        const int maxNumsLength = 100;
        Span<byte> counts = stackalloc byte[maxNumsLength + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            counts[nums[i]]++;
        }

        int sum = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] == 1)
            {
                sum += i;
            }
        }

        return sum;
    }
}
