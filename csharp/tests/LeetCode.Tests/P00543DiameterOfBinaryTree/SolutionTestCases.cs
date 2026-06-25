using Xunit;

namespace LeetCode.Tests.P00543DiameterOfBinaryTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int> DiameterOfBinaryTreeCases =>
        new()
        {
            { [1, 2, 3, 4, 5], 3 },
            { [1, 2], 1 },
            { [1], 0 },
        };
}
