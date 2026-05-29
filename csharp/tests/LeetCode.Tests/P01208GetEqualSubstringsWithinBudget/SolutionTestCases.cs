using Xunit;

namespace LeetCode.Tests.P01208GetEqualSubstringsWithinBudget;

public static class SolutionTestCases
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
}
