namespace LeetCode.P00200NumberOfIslands.Initial;

/// <summary>
/// LeetCode 200. Number of Islands.
/// https://leetcode.com/problems/number-of-islands/
/// </summary>
public sealed class Solution
{
    public int NumIslands(char[][] grid)
    {
        const char land = '1';
        const char water = '0';
        int islandCount = 0;

        int rows = grid.Length;
        int columns = grid[0].Length;

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                if (grid[row][column] == land)
                {
                    islandCount++;
                    SinkIsland(row, column);
                }
            }
        }

        return islandCount;

        void SinkIsland(int row, int column)
        {
            if (row < 0 || row >= rows
                || column < 0 || column >= columns
                || grid[row][column] == water)
            {
                return;
            }

            grid[row][column] = water;

            SinkIsland(row + 1, column);
            SinkIsland(row - 1, column);
            SinkIsland(row, column + 1);
            SinkIsland(row, column - 1);
        }
    }
}
