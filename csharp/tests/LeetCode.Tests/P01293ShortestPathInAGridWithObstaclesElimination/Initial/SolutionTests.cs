using LeetCode.P01293ShortestPathInAGridWithObstaclesElimination.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01293ShortestPathInAGridWithObstaclesElimination.SolutionTestCases;

namespace LeetCode.Tests.P01293ShortestPathInAGridWithObstaclesElimination.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ShortestPathCases), MemberType = typeof(RootSolutionTestCases))]
    public void ShortestPath_ReturnsMinimumNumberOfSteps(int[][] grid, int k, int expected)
    {
        Solution solution = new();

        int actual = solution.ShortestPath(grid, k);

        Assert.Equal(expected, actual);
    }
}
