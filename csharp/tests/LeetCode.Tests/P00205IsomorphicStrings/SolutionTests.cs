using LeetCode.P00205IsomorphicStrings;
using Xunit;

namespace LeetCode.Tests.P00205IsomorphicStrings;

public sealed class SolutionTests
{
    public static TheoryData<string, string, bool> IsIsomorphicCases =>
        new()
        {
            { "egg", "add", true },
            { "foo", "bar", false },
            { "paper", "title", true },
            { "badc", "baba", false },
        };

    [Theory]
    [MemberData(nameof(IsIsomorphicCases))]
    public void IsIsomorphic_ReturnsWhetherStringsAreIsomorphic(string s, string t, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsIsomorphic(s, t);

        Assert.Equal(expected, actual);
    }
}
