using LeetCode.P00557ReverseWordsInAStringIII;
using Xunit;

namespace LeetCode.Tests.P00557ReverseWordsInAStringIII;

public sealed class SolutionTests
{
    public static TheoryData<string, string> ReverseWordsCases =>
        new()
        {
            { "Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc" },
            { "God Ding", "doG gniD" },
        };

    [Theory]
    [MemberData(nameof(ReverseWordsCases))]
    public void ReverseWords_ReturnsExpectedString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.ReverseWords(s);

        Assert.Equal(expected, actual);
    }
}
