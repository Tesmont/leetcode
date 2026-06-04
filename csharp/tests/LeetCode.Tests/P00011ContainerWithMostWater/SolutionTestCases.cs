using Xunit;

namespace LeetCode.Tests.P00011ContainerWithMostWater;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> MaxAreaCases =>
        new()
        {
            { new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49 },
            { new[] { 1, 1 }, 1 },
        };
}
