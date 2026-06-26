namespace LeetCode.P01557MinimumNumberOfVerticesToReachAllNodes.Initial;

/// <summary>
/// LeetCode 1557. Minimum Number of Vertices to Reach All Nodes.
/// https://leetcode.com/problems/minimum-number-of-vertices-to-reach-all-nodes/
/// </summary>
public sealed class Solution
{
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
    {
        Span<bool> hasIncomingEdge = stackalloc bool[n];
        foreach (IList<int> edge in edges)
        {
            hasIncomingEdge[edge[1]] = true;
        }

        List<int> result = new(n);
        for (int vertex = 0; vertex < n; vertex++)
        {
            if (!hasIncomingEdge[vertex])
            {
                result.Add(vertex);
            }
        }

        return result;
    }
}
