using Xunit;

namespace LeetCode.Tests.P0054201Matrix;

public static class SolutionTestCases
{
    public static TheoryData<int[][], int[][]> UpdateMatrixCases =>
        new()
        {
            {
                [
                    [0, 0, 0],
                    [0, 1, 0],
                    [0, 0, 0],
                ],
                [
                    [0, 0, 0],
                    [0, 1, 0],
                    [0, 0, 0],
                ]
            },
            {
                [
                    [0, 0, 0],
                    [0, 1, 0],
                    [1, 1, 1],
                ],
                [
                    [0, 0, 0],
                    [0, 1, 0],
                    [1, 2, 1],
                ]
            },
        };
}
