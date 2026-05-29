using LeetCode.P02352EqualRowAndColumnPairs;
using Xunit;

namespace LeetCode.Tests.P02352EqualRowAndColumnPairs;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.EqualPairsCases), MemberType = typeof(SolutionTestCases))]
    public void EqualPairs_ReturnsNumberOfEqualRowAndColumnPairs(int[][] grid, int expected)
    {
        Solution solution = new();

        int actual = solution.EqualPairs(grid);

        Assert.Equal(expected, actual);
    }
}
