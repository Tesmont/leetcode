using LeetCode.P01657DetermineIfTwoStringsAreClose.FrequencySort;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01657DetermineIfTwoStringsAreClose.SolutionTestCases;

namespace LeetCode.Tests.P01657DetermineIfTwoStringsAreClose.FrequencySort;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CloseStringsCases), MemberType = typeof(RootSolutionTestCases))]
    public void CloseStrings_ReturnsWhetherStringsAreClose(string word1, string word2, bool expected)
    {
        Solution solution = new();

        bool actual = solution.CloseStrings(word1, word2);

        Assert.Equal(expected, actual);
    }
}
