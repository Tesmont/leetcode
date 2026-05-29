using LeetCode.P00003LongestSubstringWithoutRepeatingCharacters;
using Xunit;

namespace LeetCode.Tests.P00003LongestSubstringWithoutRepeatingCharacters;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.LengthOfLongestSubstringCases), MemberType = typeof(SolutionTestCases))]
    public void LengthOfLongestSubstring_ReturnsLengthOfLongestSubstringWithoutRepeatingCharacters(
        string text,
        int expected)
    {
        Solution solution = new();

        int actual = solution.LengthOfLongestSubstring(text);

        Assert.Equal(expected, actual);
    }
}
