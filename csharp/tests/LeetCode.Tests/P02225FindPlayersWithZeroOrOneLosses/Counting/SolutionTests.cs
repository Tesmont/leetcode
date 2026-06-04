using LeetCode.P02225FindPlayersWithZeroOrOneLosses.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02225FindPlayersWithZeroOrOneLosses.SolutionTestCases;

namespace LeetCode.Tests.P02225FindPlayersWithZeroOrOneLosses.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.FindWinnersCases), MemberType = typeof(RootSolutionTestCases))]
    public void FindWinners_ReturnsPlayersWithZeroOrOneLosses(int[][] matches, int[][] expected)
    {
        Solution solution = new();

        IList<IList<int>> actual = solution.FindWinners(matches);

        Assert.Equal(expected, actual);
    }
}
