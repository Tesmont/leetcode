using Xunit;

namespace LeetCode.Tests.P00346MovingAverageFromDataStream;

public static class SolutionTestCases
{
    public static TheoryData<int, int[], double[]> NextCases =>
        new()
        {
            { 3, [1, 10, 3, 5], [1.0, 5.5, 4.66667, 6.0] },
            { 1, [4, 0, -2], [4.0, 0.0, -2.0] },
        };
}
