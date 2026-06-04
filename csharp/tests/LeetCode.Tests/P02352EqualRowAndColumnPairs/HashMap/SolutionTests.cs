using LeetCode.P02352EqualRowAndColumnPairs.HashMap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02352EqualRowAndColumnPairs.SolutionTestCases;

namespace LeetCode.Tests.P02352EqualRowAndColumnPairs.HashMap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.EqualPairsCases), MemberType = typeof(RootSolutionTestCases))]
    public void EqualPairs_ReturnsNumberOfEqualRowAndColumnPairs(int[][] grid, int expected)
    {
        Solution solution = new();

        int actual = solution.EqualPairs(grid);

        Assert.Equal(expected, actual);
    }
}
