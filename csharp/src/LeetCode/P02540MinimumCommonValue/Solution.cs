namespace LeetCode.P02540MinimumCommonValue;

/// <summary>
/// LeetCode 2540. Minimum Common Value.
/// https://leetcode.com/problems/minimum-common-value/
/// </summary>
public sealed class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        int index1 = 0;
        int index2 = 0;

        while (index1 < nums1.Length && index2 < nums2.Length)
        {
            if (nums1[index1] == nums2[index2])
            {
                return nums1[index1];
            }

            if (nums1[index1] < nums2[index2])
            {
                index1++;
            }
            else
            {
                index2++;
            }
        }

        return -1;
    }
}
