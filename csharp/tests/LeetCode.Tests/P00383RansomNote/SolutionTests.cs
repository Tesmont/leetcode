using LeetCode.P00383RansomNote;
using Xunit;

namespace LeetCode.Tests.P00383RansomNote;

public sealed class SolutionTests
{
    public static TheoryData<string, string, bool> CanConstructCases =>
        new()
        {
            { "a", "b", false },
            { "aa", "ab", false },
            { "aa", "aab", true },
            { new string('a', 40_000), new string('a', 40_000), true },
        };

    [Theory]
    [MemberData(nameof(CanConstructCases))]
    public void CanConstruct_ReturnsWhetherRansomNoteCanBeConstructed(
        string ransomNote,
        string magazine,
        bool expected)
    {
        Solution solution = new();

        bool actual = solution.CanConstruct(ransomNote, magazine);

        Assert.Equal(expected, actual);
    }
}
