using Xunit;

namespace LeetCode.Tests.P00909SnakesAndLadders;

public static class SolutionTestCases
{
    public static TheoryData<int[][], int> SnakesAndLaddersCases =>
        new()
        {
            {
                [
                    [-1, -1, -1, -1, -1, -1],
                    [-1, -1, -1, -1, -1, -1],
                    [-1, -1, -1, -1, -1, -1],
                    [-1, 35, -1, -1, 13, -1],
                    [-1, -1, -1, -1, -1, -1],
                    [-1, 15, -1, -1, -1, -1],
                ],
                4
            },
            {
                [
                    [-1, -1],
                    [-1, 3],
                ],
                1
            },
        };
}
