using Xunit;

namespace LeetCode.Tests.P00203RemoveLinkedListElements;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int[]> RemoveElementsCases =>
        new()
        {
            { [1, 2, 6, 3, 4, 5, 6], 6, [1, 2, 3, 4, 5] },
            { [], 1, [] },
            { [7, 7, 7, 7], 7, [] },
        };
}
