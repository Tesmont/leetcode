using LeetCode.P02352EqualRowAndColumnPairs;
using Xunit;

namespace LeetCode.Tests.P02352EqualRowAndColumnPairs;

public sealed class SolutionTests
{
    public static TheoryData<int[][], int> EqualPairsCases =>
        new()
        {
            {
                [
                    [3, 2, 1],
                    [1, 7, 6],
                    [2, 7, 7],
                ],
                1
            },
            {
                [
                    [3, 1, 2, 2],
                    [1, 4, 4, 5],
                    [2, 4, 2, 2],
                    [2, 4, 2, 2],
                ],
                3
            },
            { [[1]], 1 },
        };

    [Theory]
    [MemberData(nameof(EqualPairsCases))]
    public void EqualPairs_ReturnsNumberOfEqualRowAndColumnPairs(int[][] grid, int expected)
    {
        Solution solution = new();

        int actual = solution.EqualPairs(grid);

        Assert.Equal(expected, actual);
    }
}
