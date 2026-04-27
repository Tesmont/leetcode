using Xunit;

namespace LeetCode.Tests.P00392IsSubsequence;

public static class SolutionTestCases
{
    public static TheoryData<string, string, bool> IsSubsequenceCases =>
        new()
        {
            { "abc", "ahbgdc", true },
            { "axc", "ahbgdc", false },
            { "", "ahbgdc", true },
        };
}
