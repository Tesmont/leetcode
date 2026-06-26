using LeetCode.P00200NumberOfIslands.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00200NumberOfIslands.SolutionTestCases;

namespace LeetCode.Tests.P00200NumberOfIslands.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.NumIslandsCases), MemberType = typeof(RootSolutionTestCases))]
    public void NumIslands_ReturnsNumberOfIslands(char[][] grid, int expected)
    {
        Solution solution = new();

        int actual = solution.NumIslands(grid);

        Assert.Equal(expected, actual);
    }
}
