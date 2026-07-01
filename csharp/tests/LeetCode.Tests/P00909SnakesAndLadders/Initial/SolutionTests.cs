using LeetCode.P00909SnakesAndLadders.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00909SnakesAndLadders.SolutionTestCases;

namespace LeetCode.Tests.P00909SnakesAndLadders.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SnakesAndLaddersCases), MemberType = typeof(RootSolutionTestCases))]
    public void SnakesAndLadders_ReturnsFewestMoves(int[][] board, int expected)
    {
        Solution solution = new();

        int actual = solution.SnakesAndLadders(board);

        Assert.Equal(expected, actual);
    }
}
