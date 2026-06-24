using Xunit;

namespace LeetCode.Tests.P00104MaximumDepthOfBinaryTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int> MaxDepthCases =>
        new()
        {
            { [3, 9, 20, null, null, 15, 7], 3 },
            { [1, null, 2], 2 },
            { [], 0 },
        };
}
