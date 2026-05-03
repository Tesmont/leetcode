using LeetCode.P02351FirstLetterToAppearTwice.Array;
using Xunit;

namespace LeetCode.Tests.P02351FirstLetterToAppearTwice.Array;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(
        nameof(LeetCode.Tests.P02351FirstLetterToAppearTwice.SolutionTestCases.RepeatedCharacterCases),
        MemberType = typeof(LeetCode.Tests.P02351FirstLetterToAppearTwice.SolutionTestCases))]
    public void RepeatedCharacter_ReturnsFirstLetterToAppearTwice(string s, char expected)
    {
        Solution solution = new();

        char actual = solution.RepeatedCharacter(s);

        Assert.Equal(expected, actual);
    }
}
