using Xunit;

namespace LeetCode.Tests.P00383RansomNote;

public static class SolutionTestCases
{
    public static TheoryData<string, string, bool> CanConstructCases =>
        new()
        {
            { "a", "b", false },
            { "aa", "ab", false },
            { "aa", "aab", true },
            { new string('a', 40_000), new string('a', 40_000), true },
        };
}
