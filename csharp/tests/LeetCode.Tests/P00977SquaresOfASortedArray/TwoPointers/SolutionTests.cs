using LeetCode.P00977SquaresOfASortedArray.TwoPointers;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00977SquaresOfASortedArray.SolutionTestCases;

namespace LeetCode.Tests.P00977SquaresOfASortedArray.TwoPointers;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.SortedSquaresCases), MemberType = typeof(RootSolutionTestCases))]
    public void SortedSquares_ReturnsSortedSquares(int[] nums, int[] expected)
    {
        Solution solution = new();

        int[] actual = solution.SortedSquares(nums);

        Assert.Equal(expected, actual);
    }
}
