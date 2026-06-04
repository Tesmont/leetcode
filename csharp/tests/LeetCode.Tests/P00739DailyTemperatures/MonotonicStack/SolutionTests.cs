using LeetCode.P00739DailyTemperatures.MonotonicStack;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00739DailyTemperatures.SolutionTestCases;

namespace LeetCode.Tests.P00739DailyTemperatures.MonotonicStack;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.DailyTemperaturesCases), MemberType = typeof(RootSolutionTestCases))]
    public void DailyTemperatures_ReturnsExpectedWaits(int[] temperatures, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.DailyTemperatures(temperatures);

        Assert.Equal(expected, actual);
    }
}
