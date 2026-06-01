using Xunit;

namespace LeetCode.Tests.P00020ValidParentheses;

public static class SolutionTestCases
{
    public static TheoryData<string, bool> IsValidCases =>
        new()
        {
            { "()", true },
            { "()[]{}", true },
            { "(]", false },
            { "([])", true },
            { "([)]", false },
            { "]", false },
            { "((", false },
            { "{[]}", true },
        };
}
