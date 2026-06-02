using LeetCode.P00844BackspaceStringCompare;
using Xunit;

namespace LeetCode.Tests.P00844BackspaceStringCompare;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.BackspaceCompareCases), MemberType = typeof(SolutionTestCases))]
    public void BackspaceCompare_ReturnsWhetherStringsAreEqualAfterBackspaces(string s, string t, bool expected)
    {
        Solution solution = new();

        bool actual = solution.BackspaceCompare(s, t);

        Assert.Equal(expected, actual);
    }
}
