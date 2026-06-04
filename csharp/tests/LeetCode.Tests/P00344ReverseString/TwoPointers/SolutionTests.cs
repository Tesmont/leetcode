using LeetCode.P00344ReverseString.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00344ReverseString.SolutionTestCases;

namespace LeetCode.Tests.P00344ReverseString.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ReverseStringCases), MemberType = typeof(RootSolutionTestCases))]
    public void ReverseString_ReversesArrayInPlace(char[] s, char[] expected)
    {
        Solution solution = new();

        solution.ReverseString(s);

        Assert.Equal(expected, s);
    }
}
