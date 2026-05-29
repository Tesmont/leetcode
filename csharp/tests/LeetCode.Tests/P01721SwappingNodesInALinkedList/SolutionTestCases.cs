using Xunit;

namespace LeetCode.Tests.P01721SwappingNodesInALinkedList;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int[]> SwapNodesCases =>
        new()
        {
            { [1, 2, 3, 4, 5], 2, [1, 4, 3, 2, 5] },
            { [7, 9, 6, 6, 7, 8, 3, 0, 9, 5], 5, [7, 9, 6, 6, 8, 7, 3, 0, 9, 5] },
            { [1], 1, [1] },
            { [1, 2], 1, [2, 1] },
            { [1, 2, 3], 2, [1, 2, 3] },
            { [1, 2, 3, 4], 2, [1, 3, 2, 4] },
            { [1, 2, 3, 4], 3, [1, 3, 2, 4] },
        };
}
