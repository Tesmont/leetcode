using LeetCode.P00557ReverseWordsInAStringIII;
using Xunit;

namespace LeetCode.Tests.P00557ReverseWordsInAStringIII;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.ReverseWordsCases), MemberType = typeof(SolutionTestCases))]
    public void ReverseWords_ReturnsExpectedString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.ReverseWords(s);

        Assert.Equal(expected, actual);
    }
}
