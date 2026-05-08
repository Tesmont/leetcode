using Xunit;

namespace LeetCode.Tests.P01189MaximumNumberOfBalloons;

public static class SolutionTestCases
{
    public static TheoryData<string, int> MaxNumberOfBalloonsCases =>
        new()
        {
            { "nlaebolko", 1 },
            { "loonbalxballpoon", 2 },
            { "leetcode", 0 },
            { "balloon", 1 },
        };
}
