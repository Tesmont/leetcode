using LeetCode.P00917ReverseOnlyLetters;
using Xunit;

namespace LeetCode.Tests.P00917ReverseOnlyLetters;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.ReverseOnlyLettersCases), MemberType = typeof(SolutionTestCases))]
    public void ReverseOnlyLetters_ReturnsExpectedString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.ReverseOnlyLetters(s);

        Assert.Equal(expected, actual);
    }
}
