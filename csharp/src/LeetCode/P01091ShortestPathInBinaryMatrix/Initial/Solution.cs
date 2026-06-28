namespace LeetCode.P01091ShortestPathInBinaryMatrix.Initial;

/// <summary>
/// LeetCode 1091. Shortest Path in Binary Matrix.
/// https://leetcode.com/problems/shortest-path-in-binary-matrix/
/// </summary>
public sealed class Solution
{
    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        if (grid[0][0] == 1)
        {
            return -1;
        }

        int n = grid.Length;
        int lastIndex = n - 1;

        Queue<(int row, int column)> queue = new();
        grid[0][0] = 1;
        queue.Enqueue((0, 0));

        int distance = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            distance++;

            for (int i = 0; i < levelSize; i++)
            {
                (int row, int column) = queue.Dequeue();

                if (row == lastIndex && column == lastIndex)
                {
                    return distance;
                }

                TryEnqueue(row + 1, column);
                TryEnqueue(row - 1, column);
                TryEnqueue(row, column + 1);
                TryEnqueue(row, column - 1);
                TryEnqueue(row + 1, column + 1);
                TryEnqueue(row + 1, column - 1);
                TryEnqueue(row - 1, column + 1);
                TryEnqueue(row - 1, column - 1);
            }
        }

        return -1;

        void TryEnqueue(int nextRow, int nextColumn)
        {
            if (nextRow < 0 || nextRow >= n || nextColumn < 0 || nextColumn >= n
                || grid[nextRow][nextColumn] == 1)
            {
                return;
            }

            grid[nextRow][nextColumn] = 1;

            queue.Enqueue((nextRow, nextColumn));
        }
    }
}
