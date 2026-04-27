using LeetCode.P00977SquaresOfASortedArray;
using Xunit;

namespace LeetCode.Tests.P00977SquaresOfASortedArray;

public sealed class SolutionTests
{
    public static TheoryData<int[], int[]> SortedSquaresCases =>
        new()
        {
            { [-4, -1, 0, 3, 10], [0, 1, 9, 16, 100] },
            { [-7, -3, 2, 3, 11], [4, 9, 9, 49, 121] },
            { [0], [0] },
        };

    [Theory]
    [MemberData(nameof(SortedSquaresCases))]
    public void SortedSquares_ReturnsSortedSquares(int[] nums, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.SortedSquares(nums);

        Assert.Equal(expected, actual);
    }
}
