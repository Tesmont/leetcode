using Xunit;

namespace LeetCode.Tests.P00912SortAnArray;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> SortArrayCases =>
        new()
        {
            { [5, 2, 3, 1], [1, 2, 3, 5] },
            { [5, 1, 1, 2, 0, 0], [0, 0, 1, 1, 2, 5] },
            { [1], [1] },
            { [-2, 3, -5], [-5, -2, 3] },
            { [2, 2, 2], [2, 2, 2] },
        };
}
