using Xunit;

namespace LeetCode.Tests.P01544MakeTheStringGreat;

public static class SolutionTestCases
{
    public static TheoryData<string, string> MakeGoodCases =>
        new()
        {
            { "leEeetcode", "leetcode" },
            { "abBAcC", "" },
            { "s", "s" },
            { "", "" },
        };
}
