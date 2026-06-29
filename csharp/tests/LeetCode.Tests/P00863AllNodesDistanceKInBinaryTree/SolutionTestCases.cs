using Xunit;

namespace LeetCode.Tests.P00863AllNodesDistanceKInBinaryTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int, int, int[]> DistanceKCases =>
        new()
        {
            { [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4], 5, 2, [7, 4, 1] },
            { [1], 1, 3, [] },
        };
}
