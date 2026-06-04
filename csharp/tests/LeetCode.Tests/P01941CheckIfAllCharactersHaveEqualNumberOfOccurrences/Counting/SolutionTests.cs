using LeetCode.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences.SolutionTestCases;

namespace LeetCode.Tests.P01941CheckIfAllCharactersHaveEqualNumberOfOccurrences.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.AreOccurrencesEqualCases), MemberType = typeof(RootSolutionTestCases))]
    public void AreOccurrencesEqual_ReturnsWhetherAllCharacterOccurrencesAreEqual(string s, bool expected)
    {
        Solution solution = new();

        bool actual = solution.AreOccurrencesEqual(s);

        Assert.Equal(expected, actual);
    }
}
