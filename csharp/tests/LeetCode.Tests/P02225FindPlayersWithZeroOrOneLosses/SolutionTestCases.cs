using Xunit;

namespace LeetCode.Tests.P02225FindPlayersWithZeroOrOneLosses;

public static class SolutionTestCases
{
    public static TheoryData<int[][], int[][]> FindWinnersCases =>
        new()
        {
            {
                [[1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9]],
                [[1, 2, 10], [4, 5, 7, 8]]
            },
            {
                [[2, 3], [1, 3], [5, 4], [6, 4]],
                [[1, 2, 5, 6], []]
            },
            {
                [[1, 100_000]],
                [[1], [100_000]]
            },
        };
}
