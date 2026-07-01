using LeetCode.P0054201Matrix.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P0054201Matrix.SolutionTestCases;

namespace LeetCode.Tests.P0054201Matrix.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.UpdateMatrixCases), MemberType = typeof(RootSolutionTestCases))]
    public void UpdateMatrix_ReturnsDistanceToNearestZeroForEachCell(int[][] mat, int[][] expected)
    {
        Solution solution = new();

        int[][] actual = solution.UpdateMatrix(mat);

        Assert.Equal(expected.Length, actual.Length);

        for (int row = 0; row < expected.Length; row++)
        {
            Assert.Equal(expected[row], actual[row]);
        }
    }
}
