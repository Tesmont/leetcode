using LeetCode.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences;
using Xunit;

namespace LeetCode.Tests.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.AreOccurrencesEqualCases), MemberType = typeof(SolutionTestCases))]
    public void AreOccurrencesEqual_ReturnsWhetherAllCharacterOccurrencesAreEqual(string s, bool expected)
    {
        Solution solution = new();

        bool actual = solution.AreOccurrencesEqual(s);

        Assert.Equal(expected, actual);
    }
}
