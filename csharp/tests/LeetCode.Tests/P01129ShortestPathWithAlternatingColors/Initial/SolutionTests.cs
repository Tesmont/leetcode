using LeetCode.P01129ShortestPathWithAlternatingColors.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01129ShortestPathWithAlternatingColors.SolutionTestCases;

namespace LeetCode.Tests.P01129ShortestPathWithAlternatingColors.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(
        nameof(RootSolutionTestCases.ShortestAlternatingPathsCases),
        MemberType = typeof(RootSolutionTestCases))]
    public void ShortestAlternatingPaths_ReturnsShortestPathLengths(
        int n,
        int[][] redEdges,
        int[][] blueEdges,
        int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.ShortestAlternatingPaths(n, redEdges, blueEdges);

        Assert.Equal(expected, actual);
    }
}
