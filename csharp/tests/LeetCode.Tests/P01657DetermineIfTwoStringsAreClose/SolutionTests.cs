using LeetCode.P01657DetermineIfTwoStringsAreClose;
using Xunit;

namespace LeetCode.Tests.P01657DetermineIfTwoStringsAreClose;

public sealed class SolutionTests
{
    public static TheoryData<string, string, bool> CloseStringsCases =>
        new()
        {
            { "abc", "bca", true },
            { "a", "aa", false },
            { "cabbba", "abbccc", true },
            { "cabbba", "aabbss", false },
            { "aaabbbbccddeeeeefffff", "aaaaabbcccdddeeeeffff", false },
        };

    [Theory]
    [MemberData(nameof(CloseStringsCases))]
    public void CloseStrings_ReturnsWhetherStringsAreClose(string word1, string word2, bool expected)
    {
        Solution solution = new();

        bool actual = solution.CloseStrings(word1, word2);

        Assert.Equal(expected, actual);
    }
}
