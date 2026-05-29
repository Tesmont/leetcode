using Xunit;

namespace LeetCode.Tests.P02270NumberOfWaysToSplitArray;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> WaysToSplitArrayCases =>
        new()
        {
            { [10, 4, -8, 7], 2 },
            { [2, 3, 1, 0], 2 },
        };
}
