using Xunit;

namespace LeetCode.Tests.P00239SlidingWindowMaximum;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int[]> MaxSlidingWindowCases =>
        new()
        {
            { [1, 3, -1, -3, 5, 3, 6, 7], 3, [3, 3, 5, 5, 6, 7] },
            { [1], 1, [1] },
            { [4, 2, 12, 3], 1, [4, 2, 12, 3] },
            { [9, 8, 7, 6], 4, [9] },
            { [3, 3, 3, 3], 2, [3, 3, 3] },
            { [9, 7, 5, 3, 1], 2, [9, 7, 5, 3] },
        };
}
