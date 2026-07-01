using Xunit;

namespace LeetCode.Tests.P01926NearestExitFromEntranceInMaze;

public static class SolutionTestCases
{
    public static TheoryData<char[][], int[], int> NearestExitCases =>
        new()
        {
            {
                [
                    ['+', '+', '.', '+'],
                    ['.', '.', '.', '+'],
                    ['+', '+', '+', '.'],
                ],
                [1, 2],
                1
            },
            {
                [
                    ['+', '+', '+'],
                    ['.', '.', '.'],
                    ['+', '+', '+'],
                ],
                [1, 0],
                2
            },
            {
                [
                    ['.', '+'],
                ],
                [0, 0],
                -1
            },
        };
}
