using Xunit;

namespace LeetCode.Tests.P01047RemoveAllAdjacentDuplicatesInString;

public static class SolutionTestCases
{
    public static TheoryData<string, string> RemoveDuplicatesCases =>
        new()
        {
            { "abbaca", "ca" },
            { "azxxzy", "ay" },
            { "a", "a" },
            { "aa", string.Empty },
            { "abccba", string.Empty },
        };
}
