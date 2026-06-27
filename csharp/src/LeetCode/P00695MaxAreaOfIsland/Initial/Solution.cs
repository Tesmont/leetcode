namespace LeetCode.P00695MaxAreaOfIsland.Initial;

/// <summary>
/// LeetCode 695. Max Area of Island.
/// https://leetcode.com/problems/max-area-of-island/
/// </summary>
public sealed class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        const int water = 0;

        int rowCount = grid.Length;
        int columnCount = grid[0].Length;

        int maxIslandArea = 0;

        for (int row = 0; row < rowCount; row++)
        {
            for (int column = 0; column < columnCount; column++)
            {
                int islandArea = GetIslandArea(row, column);
                maxIslandArea = Math.Max(maxIslandArea, islandArea);
            }
        }

        return maxIslandArea;

        int GetIslandArea(int row, int column)
        {
            if (row < 0 || row >= rowCount || column < 0 || column >= columnCount)
            {
                return 0;
            }

            if (grid[row][column] == water)
            {
                return 0;
            }

            grid[row][column] = water;

            int islandArea = 1;
            islandArea += GetIslandArea(row - 1, column);
            islandArea += GetIslandArea(row + 1, column);
            islandArea += GetIslandArea(row, column - 1);
            islandArea += GetIslandArea(row, column + 1);

            return islandArea;
        }
    }
}
