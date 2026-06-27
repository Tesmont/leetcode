namespace LeetCode.P00323NumberOfConnectedComponentsInAnUndirectedGraph.Initial;

/// <summary>
/// LeetCode 323. Number of Connected Components in an Undirected Graph.
/// https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/
/// </summary>
public sealed class Solution
{
    public int CountComponents(int n, int[][] edges)
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
        int componentCount = 0;

        for (int vertex = 0; vertex < n; vertex++)
        {
            if (!seen[vertex])
            {
                componentCount++;
                Dfs(vertex);
            }
        }

        return componentCount;

        void Dfs(int vertex)
        {
            seen[vertex] = true;

            foreach (int neighborVertex in adjacencyList[vertex])
            {
                if (!seen[neighborVertex])
                {
                    Dfs(neighborVertex);
                }
            }
        }
    }
}
