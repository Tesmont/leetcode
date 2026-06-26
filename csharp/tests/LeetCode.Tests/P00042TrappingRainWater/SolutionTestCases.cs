using Xunit;

namespace LeetCode.Tests.P00042TrappingRainWater;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> TrapCases =>
        new()
        {
            { [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1], 6 },
            { [4, 2, 0, 3, 2, 5], 9 },
            { [1], 0 },
            { [1, 2, 3], 0 },
            { [3, 2, 1], 0 },
            { [2, 0, 2], 2 }
        };
}
