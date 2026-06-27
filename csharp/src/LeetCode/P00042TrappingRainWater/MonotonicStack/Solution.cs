namespace LeetCode.P00042TrappingRainWater.MonotonicStack;

/// <summary>
/// LeetCode 42. Trapping Rain Water.
/// https://leetcode.com/problems/trapping-rain-water/
/// </summary>
public sealed class Solution
{
    public int Trap(int[] height)
    {
        Span<int> monotonicStack = stackalloc int[height.Length];
        int stackCount = 0;
        int waterVolume = 0;

        for (int rightIndex = 0; rightIndex < height.Length; rightIndex++)
        {
            int rightHeight = height[rightIndex];

            while (stackCount > 0 && rightHeight > height[monotonicStack[stackCount - 1]])
            {
                stackCount--;
                if (stackCount == 0)
                {
                    break;
                }

                int bottomIndex = monotonicStack[stackCount];
                int bottomHeight = height[bottomIndex];

                int leftIndex = monotonicStack[stackCount - 1];
                int leftHeight = height[leftIndex];

                int width = rightIndex - leftIndex - 1;
                int boundedHeight = Math.Min(leftHeight, rightHeight) - bottomHeight;
                waterVolume += boundedHeight * width;
            }

            monotonicStack[stackCount] = rightIndex;
            stackCount++;
        }

        return waterVolume;
    }
}
