using Xunit;

namespace LeetCode.Tests.P00290WordPattern;

public static class SolutionTestCases
{
    public static TheoryData<string, string, bool> WordPatternCases =>
        new()
        {
            { "abba", "dog cat cat dog", true },
            { "abba", "dog cat cat fish", false },
            { "aaaa", "dog cat cat dog", false },
            { "abba", "dog dog dog dog", false },
            { "aaa", "dog dog dog dog", false },
        };
}
