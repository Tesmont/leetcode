using LeetCode.P00383RansomNote;
using Xunit;

namespace LeetCode.Tests.P00383RansomNote;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.CanConstructCases), MemberType = typeof(SolutionTestCases))]
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
