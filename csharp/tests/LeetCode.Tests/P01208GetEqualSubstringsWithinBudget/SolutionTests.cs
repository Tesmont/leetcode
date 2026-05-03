using LeetCode.P01208GetEqualSubstringsWithinBudget;
using Xunit;

namespace LeetCode.Tests.P01208GetEqualSubstringsWithinBudget;

public sealed class SolutionTests
{
    public static TheoryData<string, string, int, int> EqualSubstringCases =>
        new()
        {
            { "abcd", "bcdf", 3, 3 },
            { "abcd", "cdef", 3, 1 },
            { "abcd", "acde", 0, 1 },
            { "abcd", "wxyz", 0, 0 },
            { "a", "a", 0, 1 }
        };

    [Theory]
    [MemberData(nameof(EqualSubstringCases))]
    public void EqualSubstring_ReturnsExpectedLength(string s, string t, int maxCost, int expected)
    {
        Solution solution = new();

        int actual = solution.EqualSubstring(s, t, maxCost);

        Assert.Equal(expected, actual);
    }
}
