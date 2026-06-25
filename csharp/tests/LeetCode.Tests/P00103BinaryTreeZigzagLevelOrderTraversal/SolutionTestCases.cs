using Xunit;

namespace LeetCode.Tests.P00103BinaryTreeZigzagLevelOrderTraversal;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int[][]> ZigzagLevelOrderCases =>
        new()
        {
            { [3, 9, 20, null, null, 15, 7], [[3], [20, 9], [15, 7]] },
            { [1], [[1]] },
            { [], [] },
            { [1, 2, 3, 4, null, null, 5], [[1], [3, 2], [4, 5]] },
        };
}
