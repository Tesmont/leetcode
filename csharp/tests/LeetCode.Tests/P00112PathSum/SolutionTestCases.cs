using Xunit;

namespace LeetCode.Tests.P00112PathSum;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int, bool> HasPathSumCases =>
        new()
        {
            { [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1], 22, true },
            { [1, 2, 3], 5, false },
            { [], 0, false },
            { [1, 2], 1, false },
            { [1, -2], -1, true },
        };
}
