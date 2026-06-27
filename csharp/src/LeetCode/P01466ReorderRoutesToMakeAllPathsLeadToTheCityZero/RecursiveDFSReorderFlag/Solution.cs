namespace LeetCode.P01466ReorderRoutesToMakeAllPathsLeadToTheCityZero.RecursiveDFSReorderFlag;

/// <summary>
/// LeetCode 1466. Reorder Routes to Make All Paths Lead to the City Zero.
/// https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero/
/// </summary>
public sealed class Solution
{
    public int MinReorder(int n, int[][] connections)
    {
        List<(int nextVertex, int cost)>[] adjacencyList = new List<(int nextVertex, int cost)>[n];
        for (int i = 0; i < n; i++)
        {
            adjacencyList[i] = [];
        }

        foreach (int[] edge in connections)
        {
            int from = edge[0];
            int to = edge[1];

            adjacencyList[from].Add((to, 1));
            adjacencyList[to].Add((from, 0));
        }

        bool[] seen = new bool[n];
        int reorderCount = 0;

        Dfs(0);

        return reorderCount;

        void Dfs(int vertex)
        {
            seen[vertex] = true;

            foreach ((int nextVertex, int cost) neighbor in adjacencyList[vertex])
            {
                if (!seen[neighbor.nextVertex])
                {
                    reorderCount += neighbor.cost;
                    Dfs(neighbor.nextVertex);
                }
            }
        }
    }
}
