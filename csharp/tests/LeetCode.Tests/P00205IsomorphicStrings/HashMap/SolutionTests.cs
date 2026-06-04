using LeetCode.P00205IsomorphicStrings.HashMap;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00205IsomorphicStrings.SolutionTestCases;

namespace LeetCode.Tests.P00205IsomorphicStrings.HashMap;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.IsIsomorphicCases), MemberType = typeof(RootSolutionTestCases))]
    public void IsIsomorphic_ReturnsWhetherStringsAreIsomorphic(string s, string t, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsIsomorphic(s, t);

        Assert.Equal(expected, actual);
    }
}
