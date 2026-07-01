namespace LeetCode.P01926NearestExitFromEntranceInMaze.Initial;

/// <summary>
/// LeetCode 1926. Nearest Exit from Entrance in Maze.
/// https://leetcode.com/problems/nearest-exit-from-entrance-in-maze/
/// </summary>
public sealed class Solution
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        const char wall = '+';

        int m = maze.Length;
        int n = maze[0].Length;

        Span<(int RowShift, int ColumnShift)> directions =
        [
          (1, 0),
          (-1, 0),
          (0, 1),
          (0, -1)
        ];

        Queue<(int Row, int Column)> queue = new();

        maze[entrance[0]][entrance[1]] = wall;
        queue.Enqueue((entrance[0], entrance[1]));

        int distance = 0;

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
                        || maze[nextRow][nextColumn] == wall)
                    {
                        continue;
                    }

                    if (nextRow == 0 || nextRow == m - 1
                        || nextColumn == 0 || nextColumn == n - 1)
                    {
                        return distance + 1;
                    }

                    maze[nextRow][nextColumn] = wall;
                    queue.Enqueue((nextRow, nextColumn));
                }
            }

            distance++;
        }

        return -1;
    }
}
