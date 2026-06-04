using LeetCode.P00392IsSubsequence.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00392IsSubsequence.SolutionTestCases;

namespace LeetCode.Tests.P00392IsSubsequence.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.IsSubsequenceCases), MemberType = typeof(RootSolutionTestCases))]
    public void IsSubsequence_ReturnsWhetherSIsASubsequenceOfT(string s, string t, bool expected)
    {
        Solution solution = new();

        bool actual = solution.IsSubsequence(s, t);

        Assert.Equal(expected, actual);
    }
}
