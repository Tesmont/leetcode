using LeetCode.P01091ShortestPathInBinaryMatrix.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P01091ShortestPathInBinaryMatrix.SolutionTestCases;

namespace LeetCode.Tests.P01091ShortestPathInBinaryMatrix.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(
        nameof(RootSolutionTestCases.ShortestPathBinaryMatrixCases),
        MemberType = typeof(RootSolutionTestCases))]
    public void ShortestPathBinaryMatrix_ReturnsShortestClearPathLength(int[][] grid, int expected)
    {
        Solution solution = new();

        int actual = solution.ShortestPathBinaryMatrix(grid);

        Assert.Equal(expected, actual);
    }
}
