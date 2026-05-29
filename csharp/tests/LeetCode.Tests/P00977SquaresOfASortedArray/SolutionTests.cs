using LeetCode.P00977SquaresOfASortedArray;
using Xunit;

namespace LeetCode.Tests.P00977SquaresOfASortedArray;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(SolutionTestCases.SortedSquaresCases), MemberType = typeof(SolutionTestCases))]
    public void SortedSquares_ReturnsSortedSquares(int[] nums, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.SortedSquares(nums);

        Assert.Equal(expected, actual);
    }
}
