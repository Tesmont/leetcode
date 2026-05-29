using Xunit;

namespace LeetCode.Tests.P00643MaximumAverageSubarrayI;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, double> FindMaxAverageCases =>
        new()
        {
            { [1, 12, -5, -6, 50, 3], 4, 12.75 },
            { [5], 1, 5.0 },
        };
}
