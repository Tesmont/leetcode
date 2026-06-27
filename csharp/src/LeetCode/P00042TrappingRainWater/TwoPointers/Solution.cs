namespace LeetCode.P00042TrappingRainWater.TwoPointers;

/// <summary>
/// LeetCode 42. Trapping Rain Water.
/// https://leetcode.com/problems/trapping-rain-water/
/// </summary>
public sealed class Solution
{
    public int Trap(int[] height)
    {
        if (height.Length < 3)
        {
            return 0;
        }

        int leftIndex = 0;
        int rightIndex = height.Length - 1;
        int leftMaxHeight = 0;
        int rightMaxHeight = 0;
        int waterVolume = 0;

        while (leftIndex < rightIndex)
        {
            int leftHeight = height[leftIndex];
            int rightHeight = height[rightIndex];

            leftMaxHeight = Math.Max(leftMaxHeight, leftHeight);
            rightMaxHeight = Math.Max(rightMaxHeight, rightHeight);

            if (leftMaxHeight < rightMaxHeight)
            {
                waterVolume += leftMaxHeight - leftHeight;
                leftIndex++;
            }
            else
            {
                waterVolume += rightMaxHeight - rightHeight;
                rightIndex--;
            }
        }

        return waterVolume;
    }
}
