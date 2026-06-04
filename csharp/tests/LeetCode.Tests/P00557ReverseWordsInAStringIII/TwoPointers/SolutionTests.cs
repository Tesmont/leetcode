using LeetCode.P00557ReverseWordsInAStringIII.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00557ReverseWordsInAStringIII.SolutionTestCases;

namespace LeetCode.Tests.P00557ReverseWordsInAStringIII.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ReverseWordsCases), MemberType = typeof(RootSolutionTestCases))]
    public void ReverseWords_ReturnsExpectedString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.ReverseWords(s);

        Assert.Equal(expected, actual);
    }
}
