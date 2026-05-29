using Xunit;

namespace LeetCode.Tests.P00917ReverseOnlyLetters;

public static class SolutionTestCases
{
    public static TheoryData<string, string> ReverseOnlyLettersCases =>
        new()
        {
            { "ab-cd", "dc-ba" },
            { "a-bC-dEf-ghIj", "j-Ih-gfE-dCba" },
            { "Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!" },
        };
}
