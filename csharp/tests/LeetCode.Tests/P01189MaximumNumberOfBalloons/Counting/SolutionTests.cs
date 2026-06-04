using LeetCode.P01189MaximumNumberOfBalloons.Counting;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01189MaximumNumberOfBalloons.SolutionTestCases;

namespace LeetCode.Tests.P01189MaximumNumberOfBalloons.Counting;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaxNumberOfBalloonsCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaxNumberOfBalloons_ReturnsExpectedCount(string text, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxNumberOfBalloons(text);

        Assert.Equal(expected, actual);
    }
}
