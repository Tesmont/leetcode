using Xunit;

namespace LeetCode.Tests.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences;

public static class SolutionTestCases
{
    public static TheoryData<string, bool> AreOccurrencesEqualCases =>
        new()
        {
            { "abacbc", true },
            { "aaabb", false },
            { "a", true },
            { "abc", true },
        };
}
