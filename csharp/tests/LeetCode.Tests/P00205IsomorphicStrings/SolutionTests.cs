using LeetCode.P00205IsomorphicStrings;
using Xunit;

namespace LeetCode.Tests.P00205IsomorphicStrings;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.IsIsomorphicCases), MemberType = typeof(SolutionTestCases))]
    public void IsIsomorphic_ReturnsWhetherStringsAreIsomorphic(string s, string t, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsIsomorphic(s, t);

        Assert.Equal(expected, actual);
    }
}
