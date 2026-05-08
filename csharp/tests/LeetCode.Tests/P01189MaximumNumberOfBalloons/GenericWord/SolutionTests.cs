using LeetCode.P01189MaximumNumberOfBalloons.GenericWord;
using Xunit;

namespace LeetCode.Tests.P01189MaximumNumberOfBalloons.GenericWord;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(
        nameof(P01189MaximumNumberOfBalloons.SolutionTestCases.MaxNumberOfBalloonsCases),
        MemberType = typeof(P01189MaximumNumberOfBalloons.SolutionTestCases))]
    public void MaxNumberOfBalloons_ReturnsExpectedCount(string text, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxNumberOfBalloons(text);

        Assert.Equal(expected, actual);
    }
}
