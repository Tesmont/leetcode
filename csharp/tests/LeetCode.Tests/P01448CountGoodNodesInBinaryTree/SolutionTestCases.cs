using Xunit;

namespace LeetCode.Tests.P01448CountGoodNodesInBinaryTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int> GoodNodesCases =>
        new()
        {
            { [3, 1, 4, 3, null, 1, 5], 4 },
            { [3, 3, null, 4, 2], 3 },
            { [1], 1 },
        };
}
