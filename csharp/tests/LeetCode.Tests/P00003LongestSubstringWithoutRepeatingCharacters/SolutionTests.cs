using LeetCode.P00003LongestSubstringWithoutRepeatingCharacters;
using Xunit;

namespace LeetCode.Tests.P00003LongestSubstringWithoutRepeatingCharacters;

public sealed class SolutionTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData(" ", 1)]
    [InlineData("aA1! a", 5)]
    public void LengthOfLongestSubstring_ReturnsLengthOfLongestSubstringWithoutRepeatingCharacters(
        string text,
        int expected)
    {
        Solution solution = new();

        int actual = solution.LengthOfLongestSubstring(text);

        Assert.Equal(expected, actual);
    }
}
