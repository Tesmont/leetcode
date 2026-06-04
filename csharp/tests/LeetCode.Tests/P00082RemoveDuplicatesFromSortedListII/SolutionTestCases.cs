using Xunit;

namespace LeetCode.Tests.P00082RemoveDuplicatesFromSortedListII;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> DeleteDuplicatesCases =>
        new()
        {
            { [1, 2, 3, 3, 4, 4, 5], [1, 2, 5] },
            { [1, 1, 1, 2, 3], [2, 3] },
            { [], [] },
            { [1, 1], [] },
            { [1, 2, 2], [1] },
        };
}
