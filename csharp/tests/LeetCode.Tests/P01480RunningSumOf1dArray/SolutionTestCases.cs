using Xunit;

namespace LeetCode.Tests.P01480RunningSumOf1dArray;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> RunningSumCases =>
        new()
        {
            { [1, 2, 3, 4], [1, 3, 6, 10] },
            { [1, 1, 1, 1, 1], [1, 2, 3, 4, 5] },
            { [3, 1, 2, 10, 1], [3, 4, 6, 16, 17] },
        };
}
