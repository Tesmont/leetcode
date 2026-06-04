using LeetCode.P00844BackspaceStringCompare.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00844BackspaceStringCompare.SolutionTestCases;

namespace LeetCode.Tests.P00844BackspaceStringCompare.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.BackspaceCompareCases), MemberType = typeof(RootSolutionTestCases))]
    public void BackspaceCompare_ReturnsWhetherStringsAreEqualAfterBackspaces(string s, string t, bool expected)
    {
        Solution solution = new();

        bool actual = solution.BackspaceCompare(s, t);

        Assert.Equal(expected, actual);
    }
}
