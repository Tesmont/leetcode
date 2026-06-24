using Xunit;

namespace LeetCode.Tests.P00111MinimumDepthOfBinaryTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int> MinDepthCases =>
        new()
        {
            { [3, 9, 20, null, null, 15, 7], 2 },
            { [2, null, 3, null, 4, null, 5, null, 6], 5 },
            { [], 0 },
        };
}
