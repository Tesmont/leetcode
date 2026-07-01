namespace LeetCode.P01293ShortestPathInAGridWithObstaclesElimination.Initial;

/// <summary>
/// LeetCode 1293. Shortest Path in a Grid with Obstacles Elimination.
/// https://leetcode.com/problems/shortest-path-in-a-grid-with-obstacles-elimination/
/// </summary>
public sealed class Solution
{
    public int ShortestPath(int[][] grid, int k)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        if (m == 1 && n == 1)
        {
            return 0;
        }

        if (k >= m + n - 3)
        {
            return m + n - 2;
        }

        int targetRow = m - 1;
        int targetColumn = n - 1;

        int[][] bestRemainingK = new int[m][];
        for (int row = 0; row < m; row++)
        {
            bestRemainingK[row] = new int[n];
            Array.Fill(bestRemainingK[row], -1);
        }

        Queue<(int Row, int Column, int RemainingK)> queue = new();

        bestRemainingK[0][0] = k;
        queue.Enqueue((0, 0, k));

        (int RowShift, int ColumnShift)[] directions =
        [
            (1, 0),
            (-1, 0),
            (0, 1),
            (0, -1)
        ];

        int distance = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                (int row, int column, int remainingK) = queue.Dequeue();

                if (row == targetRow && column == targetColumn)
                {
                    return distance;
                }

                foreach ((int rowShift, int columnShift) in directions)
                {
                    int nextRow = row + rowShift;
                    int nextColumn = column + columnShift;

                    if (nextRow < 0 || nextRow >= m ||
                        nextColumn < 0 || nextColumn >= n)
                    {
                        continue;
                    }

                    int nextRemainingK = remainingK - grid[nextRow][nextColumn];

                    if (nextRemainingK < 0)
                    {
                        continue;
                    }

                    if (nextRemainingK <= bestRemainingK[nextRow][nextColumn])
                    {
                        continue;
                    }

                    bestRemainingK[nextRow][nextColumn] = nextRemainingK;
                    queue.Enqueue((nextRow, nextColumn, nextRemainingK));
                }
            }

            distance++;
        }

        return -1;
    }
}
