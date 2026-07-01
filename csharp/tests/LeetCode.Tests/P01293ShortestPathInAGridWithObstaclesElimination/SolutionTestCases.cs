using Xunit;

namespace LeetCode.Tests.P01293ShortestPathInAGridWithObstaclesElimination;

public static class SolutionTestCases
{
    public static TheoryData<int[][], int, int> ShortestPathCases =>
        new()
        {
            {
                [
                    [0, 0, 0],
                    [1, 1, 0],
                    [0, 0, 0],
                    [0, 1, 1],
                    [0, 0, 0],
                ],
                1,
                6
            },
            {
                [
                    [0, 1, 1],
                    [1, 1, 1],
                    [1, 0, 0],
                ],
                1,
                -1
            },
        };
}
