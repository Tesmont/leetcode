using Xunit;

namespace LeetCode.Tests.P02248IntersectionOfMultipleArrays;

public static class SolutionTestCases
{
    public static TheoryData<int[][], int[]> IntersectionCases =>
        new()
        {
            { [[3, 1, 2, 4, 5], [1, 2, 3, 4], [3, 4, 5, 6]], [3, 4] },
            { [[1, 2, 3], [4, 5, 6]], [] },
        };
}
