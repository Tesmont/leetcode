namespace LeetCode.P02101DetonateTheMaximumBombs.Initial;

/// <summary>
/// LeetCode 2101. Detonate the Maximum Bombs.
/// https://leetcode.com/problems/detonate-the-maximum-bombs/
/// </summary>
public sealed class Solution
{
    public int MaximumDetonation(int[][] bombs)
    {
        int n = bombs.Length;
        List<int>[] adjecancyList = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            adjecancyList[i] = new();

            int x1 = bombs[i][0];
            int y1 = bombs[i][1];
            int r1 = bombs[i][2];

            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                int x2 = bombs[j][0];
                int y2 = bombs[j][1];

                if (CanDetonate(x1, y1, r1, x2, y2))
                {
                    adjecancyList[i].Add(j);
                }
            }
        }

        int maxDetonationCount = 0;
        Span<bool> seen = stackalloc bool[n];
        Span<int> stack = stackalloc int[n];

        for (int i = 0; i < n; i++)
        {
            seen.Clear();

            seen[i] = true;
            stack[0] = i;
            int stackCount = 1;
            int detonationCount = 1;

            while (stackCount > 0)
            {
                stackCount--;
                int bomb = stack[stackCount];

                foreach (int neighbor in adjecancyList[bomb])
                {
                    if (seen[neighbor])
                    {
                        continue;
                    }

                    seen[neighbor] = true;
                    detonationCount++;

                    stack[stackCount] = neighbor;
                    stackCount++;
                }
            }

            maxDetonationCount = Math.Max(maxDetonationCount, detonationCount);
        }

        return maxDetonationCount;

        static bool CanDetonate(int x1, int y1, int r1, int x2, int y2)
        {
            long dx = x1 - x2;
            long dy = y1 - y2;
            long doubleDistance = dx * dx + dy * dy;
            long doubleRadius = (long)r1 * r1;

            return doubleRadius >= doubleDistance;
        }
    }
}
