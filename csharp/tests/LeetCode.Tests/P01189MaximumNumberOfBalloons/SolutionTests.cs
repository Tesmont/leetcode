using LeetCode.P01189MaximumNumberOfBalloons;
using Xunit;

namespace LeetCode.Tests.P01189MaximumNumberOfBalloons;

public sealed class SolutionTests
{
    public static TheoryData<string, int> MaxNumberOfBalloonsCases =>
        new()
        {
            { "nlaebolko", 1 },
            { "loonbalxballpoon", 2 },
            { "leetcode", 0 },
            { "balloon", 1 },
        };

    [Theory]
    [MemberData(nameof(MaxNumberOfBalloonsCases))]
    public void MaxNumberOfBalloons_ReturnsExpectedCount(string text, int expected)
    {
        Solution solution = new();

        int actual = solution.MaxNumberOfBalloons(text);

        Assert.Equal(expected, actual);
    }
}
