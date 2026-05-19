using LeetCode.P00290WordPattern.ReadOnlyMemory;
using Xunit;

namespace LeetCode.Tests.P00290WordPattern.ReadOnlyMemory;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.WordPatternCases), MemberType = typeof(SolutionTestCases))]
    public void WordPattern_ReturnsWhetherWordsFollowPattern(string pattern, string s, bool expected)
    {
        Solution solution = new();

        bool actual = solution.WordPattern(pattern, s);

        Assert.Equal(expected, actual);
    }
}
