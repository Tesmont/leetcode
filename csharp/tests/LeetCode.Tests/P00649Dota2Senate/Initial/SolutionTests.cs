using LeetCode.P00649Dota2Senate.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00649Dota2Senate.SolutionTestCases;

namespace LeetCode.Tests.P00649Dota2Senate.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.PredictPartyVictoryCases), MemberType = typeof(RootSolutionTestCases))]
    public void PredictPartyVictory_ReturnsExpectedWinningParty(string senate, string expected)
    {
        Solution solution = new();

        string actual = solution.PredictPartyVictory(senate);

        Assert.Equal(expected, actual);
    }
}
