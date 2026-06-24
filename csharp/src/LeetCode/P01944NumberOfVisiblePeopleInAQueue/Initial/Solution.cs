namespace LeetCode.P01944NumberOfVisiblePeopleInAQueue.Initial;

/// <summary>
/// LeetCode 1944. Number of Visible People in a Queue.
/// https://leetcode.com/problems/number-of-visible-people-in-a-queue/
/// </summary>
public sealed class Solution
{
    public int[] CanSeePersonsCount(int[] heights)
    {
        int[] result = new int[heights.Length];
        Span<int> decreasingHeights = stackalloc int[heights.Length];
        int visibleBlockersCount = 0;

        for (int i = heights.Length - 1; i >= 0; i--)
        {
            int height = heights[i];

            while (visibleBlockersCount > 0
                && decreasingHeights[visibleBlockersCount - 1] < height)
            {
                result[i]++;
                visibleBlockersCount--;
            }

            if (visibleBlockersCount > 0)
            {
                result[i]++;
            }

            decreasingHeights[visibleBlockersCount++] = height;
        }

        return result;
    }
}
