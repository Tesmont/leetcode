using Xunit;

namespace LeetCode.Tests.P02000ReversePrefixOfWord;

public static class SolutionTestCases
{
    public static TheoryData<string, char, string> ReversePrefixCases =>
        new()
        {
            { "abcdefd", 'd', "dcbaefd" },
            { "xyxzxe", 'z', "zxyxxe" },
            { "abcd", 'z', "abcd" },
        };
}
