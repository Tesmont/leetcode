using LeetCode.P00383RansomNote.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00383RansomNote.SolutionTestCases;

namespace LeetCode.Tests.P00383RansomNote.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.CanConstructCases), MemberType = typeof(RootSolutionTestCases))]
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
