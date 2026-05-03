using Xunit;

namespace LeetCode.Tests.P02351FirstLetterToAppearTwice;

public static class SolutionTestCases
{
    public static TheoryData<string, char> RepeatedCharacterCases =>
        new()
        {
            { "abccbaacz", 'c' },
            { "abcdd", 'd' },
        };
}
