using Xunit;

namespace LeetCode.Tests.P02074ReverseNodesInEvenLengthGroups;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> ReverseEvenLengthGroupsCases =>
        new()
        {
            { [5, 2, 6, 3, 9, 1, 7, 3, 8, 4], [5, 6, 2, 3, 9, 1, 4, 8, 3, 7] },
            { [1, 1, 0, 6], [1, 0, 1, 6] },
            { [1, 1, 0, 6, 5], [1, 0, 1, 5, 6] },
            { [1], [1] },
            { [1, 2, 3], [1, 3, 2] },
        };
}
