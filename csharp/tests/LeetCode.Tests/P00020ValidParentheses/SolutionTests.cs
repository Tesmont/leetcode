using LeetCode.P00020ValidParentheses;
using Xunit;

namespace LeetCode.Tests.P00020ValidParentheses;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.IsValidCases), MemberType = typeof(SolutionTestCases))]
    public void IsValid_ReturnsWhetherParenthesesAreValid(string s, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsValid(s);

        Assert.Equal(expected, actual);
    }
}
