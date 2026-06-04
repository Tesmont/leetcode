using LeetCode.P00020ValidParentheses.Stack;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00020ValidParentheses.SolutionTestCases;

namespace LeetCode.Tests.P00020ValidParentheses.Stack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.IsValidCases), MemberType = typeof(RootSolutionTestCases))]
    public void IsValid_ReturnsWhetherParenthesesAreValid(string s, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsValid(s);

        Assert.Equal(expected, actual);
    }
}
