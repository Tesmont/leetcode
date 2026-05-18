using LeetCode.P00567PermutationInString;
using Xunit;

namespace LeetCode.Tests.P00567PermutationInString;

public sealed class SolutionTests
{
    [Theory]
    [InlineData("ab", "eidbaooo", true)]
    [InlineData("ab", "eidboaoo", false)]
    [InlineData("adc", "dcda", true)]
    [InlineData("hello", "ooolleoooleh", false)]
    [InlineData("a", "a", true)]
    [InlineData("abc", "ab", false)]
    public void CheckInclusion_ReturnsWhetherS2ContainsPermutationOfS1(
        string s1,
        string s2,
        bool expected)
    {
        Solution solution = new();

        bool actual = solution.CheckInclusion(s1, s2);

        Assert.Equal(expected, actual);
    }
}
