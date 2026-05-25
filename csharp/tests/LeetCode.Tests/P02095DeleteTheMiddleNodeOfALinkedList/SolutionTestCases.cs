using Xunit;

namespace LeetCode.Tests.P02095DeleteTheMiddleNodeOfALinkedList;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> DeleteMiddleCases =>
        new()
        {
            { [1, 3, 4, 7, 1, 2, 6], [1, 3, 4, 1, 2, 6] },
            { [1, 2, 3, 4], [1, 2, 4] },
            { [2, 1], [2] },
            { [1], [] },
        };
}
