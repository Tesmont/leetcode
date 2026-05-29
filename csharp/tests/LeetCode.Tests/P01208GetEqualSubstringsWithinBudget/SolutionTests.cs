using LeetCode.P01208GetEqualSubstringsWithinBudget;
using Xunit;

namespace LeetCode.Tests.P01208GetEqualSubstringsWithinBudget;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.EqualSubstringCases), MemberType = typeof(SolutionTestCases))]
    public void EqualSubstring_ReturnsExpectedLength(string s, string t, int maxCost, int expected)
    {
        Solution solution = new();

        int actual = solution.EqualSubstring(s, t, maxCost);

        Assert.Equal(expected, actual);
    }
}
