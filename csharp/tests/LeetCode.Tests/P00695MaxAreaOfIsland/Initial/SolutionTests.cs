using LeetCode.P00695MaxAreaOfIsland.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00695MaxAreaOfIsland.SolutionTestCases;

namespace LeetCode.Tests.P00695MaxAreaOfIsland.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaxAreaOfIslandCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaxAreaOfIsland_ReturnsMaximumIslandArea(int[][] grid, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxAreaOfIsland(grid);

        Assert.Equal(expected, actual);
    }
}
