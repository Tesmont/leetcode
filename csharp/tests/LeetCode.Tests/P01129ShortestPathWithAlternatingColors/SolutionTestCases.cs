using Xunit;

namespace LeetCode.Tests.P01129ShortestPathWithAlternatingColors;

public static class SolutionTestCases
{
    public static TheoryData<int, int[][], int[][], int[]> ShortestAlternatingPathsCases =>
        new()
        {
            {
                3,
                [[0, 1], [1, 2]],
                [],
                [0, 1, -1]
            },
            {
                3,
                [[0, 1]],
                [[2, 1]],
                [0, 1, -1]
            },
            {
                3,
                [[0, 1]],
                [[1, 2]],
                [0, 1, 2]
            },
        };
}
