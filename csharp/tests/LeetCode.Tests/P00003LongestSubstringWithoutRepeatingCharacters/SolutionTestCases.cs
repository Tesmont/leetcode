using Xunit;

namespace LeetCode.Tests.P00003LongestSubstringWithoutRepeatingCharacters;

public static class SolutionTestCases
{
    public static TheoryData<string, int> LengthOfLongestSubstringCases =>
        new()
        {
            { "abcabcbb", 3 },
            { "bbbbb", 1 },
            { "pwwkew", 3 },
            { "", 0 },
            { " ", 1 },
            { "aA1! a", 5 },
        };
}
