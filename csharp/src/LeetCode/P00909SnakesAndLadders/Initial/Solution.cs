namespace LeetCode.P00909SnakesAndLadders.Initial;

/// <summary>
/// LeetCode 909. Snakes and Ladders.
/// https://leetcode.com/problems/snakes-and-ladders/
/// </summary>
public sealed class Solution
{
    public int SnakesAndLadders(int[][] board)
    {
        int n = board.Length;
        int lastCell = n * n;

        Span<bool> seen = stackalloc bool[lastCell + 1];
        Queue<int> queue = new();

        seen[1] = true;
        queue.Enqueue(1);

        int distance = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                int cell = queue.Dequeue();

                int firstRolledCell = cell + 1;
                int lastRolledCell = Math.Min(cell + 6, lastCell);

                for (int rolledCell = firstRolledCell; rolledCell <= lastRolledCell; rolledCell++)
                {
                    int destinationCell = GetDestinationCell(rolledCell);

                    if (destinationCell == lastCell)
                    {
                        return distance + 1;
                    }

                    if (seen[destinationCell])
                    {
                        continue;
                    }

                    seen[destinationCell] = true;
                    queue.Enqueue(destinationCell);
                }
            }

            distance++;
        }

        return -1;

        int GetDestinationCell(int cell)
        {
            int index = cell - 1;

            int rowFromBottom = index / n;
            int columnOffset = index % n;

            int row = n - 1 - rowFromBottom;
            int column = rowFromBottom % 2 == 0
                ? columnOffset
                : n - 1 - columnOffset;

            int value = board[row][column];

            return value == -1
                ? cell
                : value;
        }
    }
}
