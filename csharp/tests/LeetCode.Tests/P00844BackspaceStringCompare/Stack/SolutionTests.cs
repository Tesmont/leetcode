using LeetCode.P00844BackspaceStringCompare.Stack;
using Xunit;

namespace LeetCode.Tests.P00844BackspaceStringCompare.Stack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(
        nameof(P00844BackspaceStringCompare.SolutionTestCases.BackspaceCompareCases),
        MemberType = typeof(P00844BackspaceStringCompare.SolutionTestCases))]
    public void BackspaceCompare_ReturnsWhetherStringsAreEqualAfterBackspaces(string s, string t, bool expected)
    {
        Solution solution = new();

        bool actual = solution.BackspaceCompare(s, t);

        Assert.Equal(expected, actual);
    }
}
