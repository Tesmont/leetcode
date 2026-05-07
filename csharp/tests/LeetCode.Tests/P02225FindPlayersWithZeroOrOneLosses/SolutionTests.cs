using LeetCode.P02225FindPlayersWithZeroOrOneLosses;
using Xunit;

namespace LeetCode.Tests.P02225FindPlayersWithZeroOrOneLosses;

public sealed class SolutionTests
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

    [Theory]
    [MemberData(nameof(FindWinnersCases))]
    public void FindWinners_ReturnsPlayersWithZeroOrOneLosses(int[][] matches, int[][] expected)
    {
        Solution solution = new();

        IList<IList<int>> actual = solution.FindWinners(matches);

        Assert.Equal(expected, actual);
    }
}
