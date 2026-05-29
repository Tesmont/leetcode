using LeetCode.P02225FindPlayersWithZeroOrOneLosses;
using Xunit;

namespace LeetCode.Tests.P02225FindPlayersWithZeroOrOneLosses;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.FindWinnersCases), MemberType = typeof(SolutionTestCases))]
    public void FindWinners_ReturnsPlayersWithZeroOrOneLosses(int[][] matches, int[][] expected)
    {
        Solution solution = new();

        IList<IList<int>> actual = solution.FindWinners(matches);

        Assert.Equal(expected, actual);
    }
}
