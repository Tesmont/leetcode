using LeetCode.P01189MaximumNumberOfBalloons;
using Xunit;

namespace LeetCode.Tests.P01189MaximumNumberOfBalloons;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.MaxNumberOfBalloonsCases), MemberType = typeof(SolutionTestCases))]
    public void MaxNumberOfBalloons_ReturnsExpectedCount(string text, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxNumberOfBalloons(text);

        Assert.Equal(expected, actual);
    }
}
