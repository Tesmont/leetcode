using LeetCode.P01466ReorderRoutesToMakeAllPathsLeadToTheCityZero.RecursiveDFSReorderFlag;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01466ReorderRoutesToMakeAllPathsLeadToTheCityZero.SolutionTestCases;

namespace LeetCode.Tests.P01466ReorderRoutesToMakeAllPathsLeadToTheCityZero.RecursiveDFSReorderFlag;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MinReorderCases), MemberType = typeof(RootSolutionTestCases))]
    public void MinReorder_ReturnsMinimumNumberOfChangedEdges(int n, int[][] connections, int expected)
    {
        Solution solution = new();

        int actual = solution.MinReorder(n, connections);

        Assert.Equal(expected, actual);
    }
}
