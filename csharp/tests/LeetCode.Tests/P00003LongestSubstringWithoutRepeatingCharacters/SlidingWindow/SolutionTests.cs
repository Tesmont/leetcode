using LeetCode.P00003LongestSubstringWithoutRepeatingCharacters.SlidingWindow;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00003LongestSubstringWithoutRepeatingCharacters.SolutionTestCases;

namespace LeetCode.Tests.P00003LongestSubstringWithoutRepeatingCharacters.SlidingWindow;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.LengthOfLongestSubstringCases), MemberType = typeof(RootSolutionTestCases))]
    public void LengthOfLongestSubstring_ReturnsLengthOfLongestSubstringWithoutRepeatingCharacters(
        string text,
        int expected)
    {
        Solution solution = new();

        int actual = solution.LengthOfLongestSubstring(text);

        Assert.Equal(expected, actual);
    }
}
