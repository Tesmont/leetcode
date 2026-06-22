using LeetCode.P02398MaximumNumberOfRobotsWithinBudget.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P02398MaximumNumberOfRobotsWithinBudget.SolutionTestCases;

namespace LeetCode.Tests.P02398MaximumNumberOfRobotsWithinBudget.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MaximumRobotsCases), MemberType = typeof(RootSolutionTestCases))]
    public void MaximumRobots_ReturnsMaximumNumberOfRobotsWithinBudget(
        int[] chargeTimes,
        int[] runningCosts,
        long budget,
        int expected)
    {
        Solution solution = new();

        int actual = solution.MaximumRobots(chargeTimes, runningCosts, budget);

        Assert.Equal(expected, actual);
    }
}
