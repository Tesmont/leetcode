using Xunit;

namespace LeetCode.Tests.P00236LowestCommonAncestorOfABinaryTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int, int, int> LowestCommonAncestorCases =>
        new()
        {
            { [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4], 5, 1, 3 },
            { [3, 5, 1, 6, 2, 0, 8, null, null, 7, 4], 5, 4, 5 },
            { [1, 2], 1, 2, 1 },
        };
}
