using Xunit;

namespace LeetCode.Tests.P00092ReverseLinkedListII;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int, int[]> ReverseBetweenCases =>
        new()
        {
            { [1, 2, 3, 4, 5], 2, 4, [1, 4, 3, 2, 5] },
            { [5], 1, 1, [5] },
            { [3, 5], 1, 2, [5, 3] },
        };
}
