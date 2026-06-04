using Xunit;

namespace LeetCode.Tests.P00083RemoveDuplicatesFromSortedList;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> DeleteDuplicatesCases =>
        new()
        {
            { [1, 1, 2], [1, 2] },
            { [1, 1, 2, 3, 3], [1, 2, 3] },
            { [], [] },
        };
}
