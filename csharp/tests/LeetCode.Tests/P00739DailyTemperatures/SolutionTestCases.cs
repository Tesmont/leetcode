using Xunit;

namespace LeetCode.Tests.P00739DailyTemperatures;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> DailyTemperaturesCases =>
        new()
        {
            { [73, 74, 75, 71, 69, 72, 76, 73], [1, 1, 4, 2, 1, 1, 0, 0] },
            { [30, 40, 50, 60], [1, 1, 1, 0] },
            { [30, 60, 90], [1, 1, 0] },
            { [90], [0] }
        };
}
