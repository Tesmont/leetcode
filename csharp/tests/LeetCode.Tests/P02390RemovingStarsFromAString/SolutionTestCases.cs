using Xunit;

namespace LeetCode.Tests.P02390RemovingStarsFromAString;

public static class SolutionTestCases
{
    public static TheoryData<string, string> RemoveStarsCases =>
        new()
        {
            { "leet**cod*e", "lecoe" },
            { "erase*****", string.Empty },
            { "abc", "abc" },
        };
}
