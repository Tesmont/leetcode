using LeetCode.P00739DailyTemperatures;
using Xunit;

namespace LeetCode.Tests.P00739DailyTemperatures;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.DailyTemperaturesCases), MemberType = typeof(SolutionTestCases))]
    public void DailyTemperatures_ReturnsExpectedWaits(int[] temperatures, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.DailyTemperatures(temperatures);

        Assert.Equal(expected, actual);
    }
}
