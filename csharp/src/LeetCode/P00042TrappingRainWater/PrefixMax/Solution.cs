namespace LeetCode.P00042TrappingRainWater.PrefixMax;

/// <summary>
/// LeetCode 42. Trapping Rain Water.
/// https://leetcode.com/problems/trapping-rain-water/
/// </summary>
public sealed class Solution
{
    public int Trap(int[] height)
    {
        int n = height.Length;
        if (n < 3)
        {
            return 0;
        }

        Span<int> leftMax = stackalloc int[n];
        Span<int> rightMax = stackalloc int[n];

        leftMax[0] = height[0];
        rightMax[n - 1] = height[n - 1];

        for (int i = 1; i < n; i++)
        {
            leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
        }

        for (int i = n - 2; i >= 0; i--)
        {
            rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
        }

        int waterVolume = 0;

        for (int i = 1; i < n - 1; i++)
        {
            waterVolume += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }

        return waterVolume;
    }
}
