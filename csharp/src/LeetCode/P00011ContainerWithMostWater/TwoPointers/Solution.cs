namespace LeetCode.P00011ContainerWithMostWater.TwoPointers;

/// <summary>
/// LeetCode 11. Container With Most Water.
/// https://leetcode.com/problems/container-with-most-water/
/// </summary>
public sealed class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int leftHeight = height[left];
        int rightHeight = height[right];
        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;
            int area = Math.Min(leftHeight, rightHeight) * width;

            maxArea = Math.Max(maxArea, area);

            if (leftHeight < rightHeight)
            {
                left++;
                leftHeight = height[left];
            }
            else
            {
                right--;
                rightHeight = height[right];
            }
        }

        return maxArea;
    }
}
