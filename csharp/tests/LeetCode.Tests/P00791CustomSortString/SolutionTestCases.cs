using Xunit;

namespace LeetCode.Tests.P00791CustomSortString;

public static class SolutionTestCases
{
    public static TheoryData<string, string> CustomSortStringCases =>
        new()
        {
            { "cba", "abcd" },
            { "bcafg", "abcd" },
            { "kqep", "pekeq" },
            { "abc", "aaabbbccc" },
        };
}
