namespace LeetCode.P02368ReachableNodesWithRestrictions.Initial;

/// <summary>
/// LeetCode 2368. Reachable Nodes With Restrictions.
/// https://leetcode.com/problems/reachable-nodes-with-restrictions/
/// </summary>
public sealed class Solution
{
    public int ReachableNodes(int n, int[][] edges, int[] restricted)
    {
        List<int>[] adjacencyList = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            adjacencyList[i] = [];
        }

        foreach (int[] edge in edges)
        {
            int fromVertex = edge[0];
            int toVertex = edge[1];

            adjacencyList[fromVertex].Add(toVertex);
            adjacencyList[toVertex].Add(fromVertex);
        }

        bool[] seen = new bool[n];

        foreach (int vertex in restricted)
        {
            seen[vertex] = true;
        }

        return Dfs(0);

        int Dfs(int vertex)
        {
            seen[vertex] = true;
            int seenCount = 1;

            foreach (int neighborVertex in adjacencyList[vertex])
            {
                if (!seen[neighborVertex])
                {
                    seenCount += Dfs(neighborVertex);
                }
            }

            return seenCount;
        }
    }
}
