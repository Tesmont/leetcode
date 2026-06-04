using LeetCode.P01208GetEqualSubstringsWithinBudget.SlidingWindow;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01208GetEqualSubstringsWithinBudget.SolutionTestCases;

namespace LeetCode.Tests.P01208GetEqualSubstringsWithinBudget.SlidingWindow;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.EqualSubstringCases), MemberType = typeof(RootSolutionTestCases))]
    public void EqualSubstring_ReturnsExpectedLength(string s, string t, int maxCost, int expected)
    {
        Solution solution = new();

        int actual = solution.EqualSubstring(s, t, maxCost);

        Assert.Equal(expected, actual);
    }
}
