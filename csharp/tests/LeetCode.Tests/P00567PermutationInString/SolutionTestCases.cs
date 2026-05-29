using Xunit;

namespace LeetCode.Tests.P00567PermutationInString;

public static class SolutionTestCases
{
    public static TheoryData<string, string, bool> CheckInclusionCases =>
        new()
        {
            { "ab", "eidbaooo", true },
            { "ab", "eidboaoo", false },
            { "adc", "dcda", true },
            { "hello", "ooolleoooleh", false },
            { "a", "a", true },
            { "abc", "ab", false },
        };
}
