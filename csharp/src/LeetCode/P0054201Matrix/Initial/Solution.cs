namespace LeetCode.P0054201Matrix.Initial;

/// <summary>
/// LeetCode 542. 01 Matrix.
/// https://leetcode.com/problems/01-matrix/
/// </summary>
public sealed class Solution
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;

        Queue<(int Row, int Column)> queue = new();
        int[][] result = new int[m][];

        for (int i = 0; i < m; i++)
        {
            result[i] = new int[n];

            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 0)
                {
                    queue.Enqueue((i, j));
                }
                else
                {
                    result[i][j] = -1;
                }
            }
        }

        (int RowShift, int ColumnShift)[] directions =
        [
            (1, 0), (-1, 0), (0, 1), (0, -1)
        ];
        int distance = 1;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                (int row, int column) = queue.Dequeue();
                foreach ((int rowShift, int columnShift) in directions)
                {
                    int nextRow = row + rowShift;
                    int nextColumn = column + columnShift;

                    if (nextRow < 0 || nextRow >= m
                        || nextColumn < 0 || nextColumn >= n
                        || result[nextRow][nextColumn] != -1)
                    {
                        continue;
                    }

                    result[nextRow][nextColumn] = distance;
                    queue.Enqueue((nextRow, nextColumn));
                }
            }

            distance++;
        }

        return result;
    }
}
