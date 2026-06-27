using LeetCode.P00323NumberOfConnectedComponentsInAnUndirectedGraph.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00323NumberOfConnectedComponentsInAnUndirectedGraph.SolutionTestCases;

namespace LeetCode.Tests.P00323NumberOfConnectedComponentsInAnUndirectedGraph.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CountComponentsCases), MemberType = typeof(RootSolutionTestCases))]
    public void CountComponents_ReturnsNumberOfConnectedComponents(int n, int[][] edges, int expected)
    {
        Solution solution = new();

        int actual = solution.CountComponents(n, edges);

        Assert.Equal(expected, actual);
    }
}
