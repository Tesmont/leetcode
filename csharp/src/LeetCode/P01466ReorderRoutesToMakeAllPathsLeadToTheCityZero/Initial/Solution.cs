namespace LeetCode.P01466ReorderRoutesToMakeAllPathsLeadToTheCityZero.Initial;

/// <summary>
/// LeetCode 1466. Reorder Routes to Make All Paths Lead to the City Zero.
/// https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero/
/// </summary>
public sealed class Solution
{
    public int MinReorder(int n, int[][] connections)
    {
        Dictionary<int, (List<int> inVertices, List<int> outVertices)> adjacencyList = [];
        foreach (int[] edge in connections)
        {
            int fromVertex = edge[0];
            int toVertex = edge[1];

            if (!adjacencyList.TryGetValue(fromVertex, out (List<int> inVertices, List<int> outVertices) fromAdjacencyVertices))
            {
                fromAdjacencyVertices = ([], []);
                adjacencyList.Add(fromVertex, fromAdjacencyVertices);
            }

            if (!adjacencyList.TryGetValue(toVertex, out (List<int> inVertices, List<int> outVertices) toAdjacencyVertices))
            {
                toAdjacencyVertices = ([], []);
                adjacencyList.Add(toVertex, toAdjacencyVertices);
            }

            fromAdjacencyVertices.outVertices.Add(toVertex);
            toAdjacencyVertices.inVertices.Add(fromVertex);
        }

        bool[] seen = new bool[n];
        int reorderCount = 0;

        Dfs(0);

        return reorderCount;

        void Dfs(int vertex)
        {
            seen[vertex] = true;

            (List<int> inVertices, List<int> outVertices) = adjacencyList[vertex];
            foreach (int nextVertex in inVertices)
            {
                if (!seen[nextVertex])
                {
                    Dfs(nextVertex);
                }
            }

            foreach (int nextVertex in outVertices)
            {
                if (!seen[nextVertex])
                {
                    reorderCount++;
                    Dfs(nextVertex);
                }
            }
        }
    }
}
