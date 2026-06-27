using Xunit;

namespace LeetCode.Tests.P01971FindIfPathExistsInGraph;

public static class SolutionTestCases
{
    public static TheoryData<int, int[][], int, int, bool> ValidPathCases =>
        new()
        {
            {
                3,
                [[0, 1], [1, 2], [2, 0]],
                0,
                2,
                true
            },
            {
                6,
                [[0, 1], [0, 2], [3, 5], [5, 4], [4, 3]],
                0,
                5,
                false
            },
        };
}
