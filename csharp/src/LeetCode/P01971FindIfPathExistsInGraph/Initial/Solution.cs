namespace LeetCode.P01971FindIfPathExistsInGraph.Initial;

/// <summary>
/// LeetCode 1971. Find if Path Exists in Graph.
/// https://leetcode.com/problems/find-if-path-exists-in-graph/
/// </summary>
public sealed class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
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

        return Dfs(source);

        bool Dfs(int vertex)
        {
            if (vertex == destination)
            {
                return true;
            }

            seen[vertex] = true;

            foreach (int neighborVertex in adjacencyList[vertex])
            {
                if (!seen[neighborVertex] && Dfs(neighborVertex))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
