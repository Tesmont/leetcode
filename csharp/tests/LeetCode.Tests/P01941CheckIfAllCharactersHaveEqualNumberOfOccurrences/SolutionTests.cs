using LeetCode.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences;
using Xunit;

namespace LeetCode.Tests.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences;

public sealed class SolutionTests
{
    public static TheoryData<string, bool> AreOccurrencesEqualCases =>
        new()
        {
            { "abacbc", true },
            { "aaabb", false },
            { "a", true },
            { "abc", true },
        };

    [Theory]
    [MemberData(nameof(AreOccurrencesEqualCases))]
    public void AreOccurrencesEqual_ReturnsWhetherAllCharacterOccurrencesAreEqual(string s, bool expected)
    {
        Solution solution = new();

        bool actual = solution.AreOccurrencesEqual(s);

        Assert.Equal(expected, actual);
    }
}
