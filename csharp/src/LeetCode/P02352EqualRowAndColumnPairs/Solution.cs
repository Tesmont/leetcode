using System.Diagnostics.CodeAnalysis;

namespace LeetCode.P02352EqualRowAndColumnPairs;

/// <summary>
/// LeetCode 2352. Equal Row and Column Pairs.
/// https://leetcode.com/problems/equal-row-and-column-pairs/
/// </summary>
public sealed class Solution
{
    private sealed class IntArrayComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[]? x, int[]? y) => x.SequenceEqual(y);

        public int GetHashCode([DisallowNull] int[] obj)
        {
            HashCode hashCode = new();
            foreach (int value in obj)
            {
                hashCode.Add(value);
            }

            return hashCode.ToHashCode();
        }
    }

    public int EqualPairs(int[][] grid)
    {
        Dictionary<int[], int> rows = new(new IntArrayComparer());

        for (int i = 0; i < grid.Length; i++)
        {
            rows.TryGetValue(grid[i], out int count);
            rows[grid[i]] = count + 1;
        }

        int pairsCount = 0;
        for (int col = 0; col < grid.Length; col++)
        {
            int[] column = new int[grid.Length];

            for (int row = 0; row < grid.Length; row++)
            {
                column[row] = grid[row][col];
            }

            if (rows.TryGetValue(column, out int count))
            {
                pairsCount += count;
            }
        }

        return pairsCount;
    }
}
