using LeetCode.P00344ReverseString;
using Xunit;

namespace LeetCode.Tests.P00344ReverseString;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.ReverseStringCases), MemberType = typeof(SolutionTestCases))]
    public void ReverseString_ReversesArrayInPlace(char[] s, char[] expected)
    {
        Solution solution = new();

        solution.ReverseString(s);

        Assert.Equal(expected, s);
    }
}
