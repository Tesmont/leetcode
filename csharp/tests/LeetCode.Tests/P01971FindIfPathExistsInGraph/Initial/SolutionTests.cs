using LeetCode.P01971FindIfPathExistsInGraph.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01971FindIfPathExistsInGraph.SolutionTestCases;

namespace LeetCode.Tests.P01971FindIfPathExistsInGraph.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ValidPathCases), MemberType = typeof(RootSolutionTestCases))]
    public void ValidPath_ReturnsWhetherPathExists(
        int n,
        int[][] edges,
        int source,
        int destination,
        bool expected)
    {
        Solution solution = new();

        bool actual = solution.ValidPath(n, edges, source, destination);

        Assert.Equal(expected, actual);
    }
}
