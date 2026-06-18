using Xunit;

namespace LeetCode.Tests.P02104SumOfSubarrayRanges;

public static class SolutionTestCases
{
    public static TheoryData<int[], long> SubArrayRangesCases =>
        new()
        {
            { [1, 2, 3], 4L },
            { [1, 3, 3], 4L },
            { [4, -2, -3, 4, 1], 59L },
            { [1], 0L },
            { [2, 2, 2], 0L },
        };
}
