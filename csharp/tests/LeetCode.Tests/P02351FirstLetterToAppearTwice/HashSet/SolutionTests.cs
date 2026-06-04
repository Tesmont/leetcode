using LeetCode.P02351FirstLetterToAppearTwice.HashSet;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02351FirstLetterToAppearTwice.SolutionTestCases;

namespace LeetCode.Tests.P02351FirstLetterToAppearTwice.HashSet;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.RepeatedCharacterCases), MemberType = typeof(RootSolutionTestCases))]
    public void RepeatedCharacter_ReturnsFirstLetterToAppearTwice(string s, char expected)
    {
        Solution solution = new();

        char actual = solution.RepeatedCharacter(s);

        Assert.Equal(expected, actual);
    }
}
