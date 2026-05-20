using Xunit;

namespace LeetCode.Tests.P01657DetermineIfTwoStringsAreClose;

public static class SolutionTestCases
{
    public static TheoryData<string, string, bool> CloseStringsCases =>
        new()
        {
            { "abc", "bca", true },
            { "a", "aa", false },
            { "cabbba", "abbccc", true },
            { "cabbba", "aabbss", false },
            { "aaabbbbccddeeeeefffff", "aaaaabbcccdddeeeeffff", false },
            { new string('a', 50_000) + new string('b', 50_000), new string('b', 50_000) + new string('a', 50_000), true },
        };
}
