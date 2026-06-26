using LeetCode.P01557MinimumNumberOfVerticesToReachAllNodes.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01557MinimumNumberOfVerticesToReachAllNodes.SolutionTestCases;

namespace LeetCode.Tests.P01557MinimumNumberOfVerticesToReachAllNodes.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FindSmallestSetOfVerticesCases), MemberType = typeof(RootSolutionTestCases))]
    public void FindSmallestSetOfVertices_ReturnsMinimumVertexSet(int n, int[][] edgeValues, int[] expected)
    {
        Solution solution = new();
        IList<IList<int>> edges = ToEdges(edgeValues);

        IList<int> actual = solution.FindSmallestSetOfVertices(n, edges);

        Assert.Equal(expected, actual);
    }

    private static IList<IList<int>> ToEdges(int[][] edgeValues)
    {
        List<IList<int>> edges = [];

        foreach (int[] edge in edgeValues)
        {
            edges.Add(edge);
        }

        return edges;
    }
}
