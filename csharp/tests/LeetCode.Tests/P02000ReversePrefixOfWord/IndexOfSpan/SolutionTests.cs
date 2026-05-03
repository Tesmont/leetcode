using LeetCode.P02000ReversePrefixOfWord.IndexOfSpan;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02000ReversePrefixOfWord.SolutionTestCases;

namespace LeetCode.Tests.P02000ReversePrefixOfWord.IndexOfSpan;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ReversePrefixCases), MemberType = typeof(RootSolutionTestCases))]
    public void ReversePrefix_ReturnsExpectedString(string word, char ch, string expected)
    {
        Solution solution = new();

        string actual = solution.ReversePrefix(word, ch);

        Assert.Equal(expected, actual);
    }
}
