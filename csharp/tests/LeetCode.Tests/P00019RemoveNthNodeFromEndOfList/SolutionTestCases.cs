using Xunit;

namespace LeetCode.Tests.P00019RemoveNthNodeFromEndOfList;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int[]> RemoveNthFromEndCases =>
        new()
        {
            { [1, 2, 3, 4, 5], 2, [1, 2, 3, 5] },
            { [1], 1, [] },
            { [1, 2], 1, [1] },
            { [1, 2], 2, [2] },
        };
}
