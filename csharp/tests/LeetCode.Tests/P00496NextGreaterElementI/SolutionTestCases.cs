using Xunit;

namespace LeetCode.Tests.P00496NextGreaterElementI;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[], int[]> NextGreaterElementCases =>
        new()
        {
            { [4, 1, 2], [1, 3, 4, 2], [-1, 3, -1] },
            { [2, 4], [1, 2, 3, 4], [3, -1] },
            { [1, 3, 5, 2, 4], [6, 5, 4, 3, 2, 1, 7], [7, 7, 7, 7, 7] },
        };
}
