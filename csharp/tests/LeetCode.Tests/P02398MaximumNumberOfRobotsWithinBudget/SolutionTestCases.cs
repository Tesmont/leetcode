using Xunit;

namespace LeetCode.Tests.P02398MaximumNumberOfRobotsWithinBudget;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[], long, int> MaximumRobotsCases =>
        new()
        {
            { [3, 6, 1, 3, 4], [2, 1, 3, 4, 5], 25L, 3 },
            { [11, 12, 19], [10, 8, 7], 19L, 0 },
            { [1], [1], 2L, 1 },
        };
}
