namespace LeetCode.P00496NextGreaterElementI.Initial;

/// <summary>
/// LeetCode 496. Next Greater Element I.
/// https://leetcode.com/problems/next-greater-element-i/
/// </summary>
public sealed class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        const int numMax = 10_000;

        int[] nextGreaterByValue = new int[numMax + 1];
        int[] stack = new int[nums2.Length];
        int stackIndex = -1;

        for (int i = nums2.Length - 1; i >= 0; i--)
        {
            while (stackIndex >= 0 
                && stack[stackIndex] <= nums2[i])
            {
                stackIndex--;
            }

            nextGreaterByValue[nums2[i]] = stackIndex == -1
                ? -1
                : stack[stackIndex];

            stackIndex++;
            stack[stackIndex] = nums2[i];
        }

        int[] result = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            result[i] = nextGreaterByValue[nums1[i]];
        }

        return result;
    }
}
