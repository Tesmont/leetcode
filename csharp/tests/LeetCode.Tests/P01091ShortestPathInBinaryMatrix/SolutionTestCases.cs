using Xunit;

namespace LeetCode.Tests.P01091ShortestPathInBinaryMatrix;

public static class SolutionTestCases
{
    public static TheoryData<int[][], int> ShortestPathBinaryMatrixCases =>
        new()
        {
            {
                [
                    [0, 1],
                    [1, 0],
                ],
                2
            },
            {
                [
                    [0, 0, 0],
                    [1, 1, 0],
                    [1, 1, 0],
                ],
                4
            },
            {
                [
                    [1, 0, 0],
                    [1, 1, 0],
                    [1, 1, 0],
                ],
                -1
            },
        };
}
