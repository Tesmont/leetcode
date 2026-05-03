using Xunit;

namespace LeetCode.Tests.P00283MoveZeroes;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> MoveZeroesCases =>
        new()
        {
            { [0, 1, 0, 3, 12], [1, 3, 12, 0, 0] },
            { [0], [0] },
            { [1, 0, 1], [1, 1, 0] },
            { [1, 2, 3], [1, 2, 3] },
            { [0, 0, 1], [1, 0, 0] },
            { [0, 0, 0], [0, 0, 0] },
            { [4, 0, 5, 0, 0, 6], [4, 5, 6, 0, 0, 0] },
        };
}
