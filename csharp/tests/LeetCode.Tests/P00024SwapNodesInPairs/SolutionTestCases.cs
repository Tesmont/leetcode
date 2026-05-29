using Xunit;

namespace LeetCode.Tests.P00024SwapNodesInPairs;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> SwapPairsCases =>
        new()
        {
            { [1, 2, 3, 4], [2, 1, 4, 3] },
            { [], [] },
            { [1], [1] },
            { [1, 2, 3], [2, 1, 3] },
        };
}
