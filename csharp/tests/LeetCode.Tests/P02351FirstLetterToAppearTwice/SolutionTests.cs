using LeetCode.P02351FirstLetterToAppearTwice;
using Xunit;

namespace LeetCode.Tests.P02351FirstLetterToAppearTwice;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.RepeatedCharacterCases), MemberType = typeof(SolutionTestCases))]
    public void RepeatedCharacter_ReturnsFirstLetterToAppearTwice(string s, char expected)
    {
        Solution solution = new();

        char actual = solution.RepeatedCharacter(s);

        Assert.Equal(expected, actual);
    }
}
