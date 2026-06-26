using LeetCode.P01466ReorderRoutesToMakeAllPathsLeadToTheCityZero.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01466ReorderRoutesToMakeAllPathsLeadToTheCityZero.SolutionTestCases;

namespace LeetCode.Tests.P01466ReorderRoutesToMakeAllPathsLeadToTheCityZero.Initial;

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
