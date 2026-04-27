using LeetCode.P00392IsSubsequence;
using Xunit;

namespace LeetCode.Tests.P00392IsSubsequence;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.IsSubsequenceCases), MemberType = typeof(SolutionTestCases))]
    public void IsSubsequence_ReturnsWhetherSIsASubsequenceOfT(string s, string t, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsSubsequence(s, t);

        Assert.Equal(expected, actual);
    }
}
