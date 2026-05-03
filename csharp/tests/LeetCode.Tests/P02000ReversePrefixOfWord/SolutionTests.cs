using LeetCode.P02000ReversePrefixOfWord;
using Xunit;

namespace LeetCode.Tests.P02000ReversePrefixOfWord;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.ReversePrefixCases), MemberType = typeof(SolutionTestCases))]
    public void ReversePrefix_ReturnsExpectedString(string word, char ch, string expected)
    {
        Solution solution = new();

        string actual = solution.ReversePrefix(word, ch);

        Assert.Equal(expected, actual);
    }
}
