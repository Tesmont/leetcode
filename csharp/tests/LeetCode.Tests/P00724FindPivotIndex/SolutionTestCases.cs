using Xunit;

namespace LeetCode.Tests.P00724FindPivotIndex;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> PivotIndexCases =>
        new()
        {
            { [1, 7, 3, 6, 5, 6], 3 },
            { [1, 2, 3], -1 },
            { [2, 1, -1], 0 },
        };
}
