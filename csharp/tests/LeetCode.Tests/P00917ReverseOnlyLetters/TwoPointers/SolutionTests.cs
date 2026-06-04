using LeetCode.P00917ReverseOnlyLetters.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00917ReverseOnlyLetters.SolutionTestCases;

namespace LeetCode.Tests.P00917ReverseOnlyLetters.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ReverseOnlyLettersCases), MemberType = typeof(RootSolutionTestCases))]
    public void ReverseOnlyLetters_ReturnsExpectedString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.ReverseOnlyLetters(s);

        Assert.Equal(expected, actual);
    }
}
