using LeetCode.P00917ReverseOnlyLetters;
using Xunit;

namespace LeetCode.Tests.P00917ReverseOnlyLetters;

public sealed class SolutionTests
{
    public static TheoryData<string, string> ReverseOnlyLettersCases =>
        new()
        {
            { "ab-cd", "dc-ba" },
            { "a-bC-dEf-ghIj", "j-Ih-gfE-dCba" },
            { "Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!" },
        };

    [Theory]
    [MemberData(nameof(ReverseOnlyLettersCases))]
    public void ReverseOnlyLetters_ReturnsExpectedString(string s, string expected)
    {
        Solution solution = new();

        string actual = solution.ReverseOnlyLetters(s);

        Assert.Equal(expected, actual);
    }
}
