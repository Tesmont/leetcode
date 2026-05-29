using Xunit;

namespace LeetCode.Tests.P00205IsomorphicStrings;

public static class SolutionTestCases
{
    public static TheoryData<string, string, bool> IsIsomorphicCases =>
        new()
        {
            { "egg", "add", true },
            { "foo", "bar", false },
            { "paper", "title", true },
            { "badc", "baba", false },
        };
}
