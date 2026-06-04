using LeetCode.P00290WordPattern.HashMap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00290WordPattern.SolutionTestCases;

namespace LeetCode.Tests.P00290WordPattern.HashMap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.WordPatternCases), MemberType = typeof(RootSolutionTestCases))]
    public void WordPattern_ReturnsWhetherWordsFollowPattern(string pattern, string s, bool expected)
    {
        Solution solution = new();

        bool actual = solution.WordPattern(pattern, s);

        Assert.Equal(expected, actual);
    }
}
