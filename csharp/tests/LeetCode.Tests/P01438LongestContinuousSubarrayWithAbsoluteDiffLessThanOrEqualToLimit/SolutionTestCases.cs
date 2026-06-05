using Xunit;

namespace LeetCode.Tests.P01438LongestContinuousSubarrayWithAbsoluteDiffLessThanOrEqualToLimit;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int> LongestSubarrayCases =>
        new()
        {
            { [8, 2, 4, 7], 4, 2 },
            { [10, 1, 2, 4, 7, 2], 5, 4 },
            { [4, 2, 2, 2, 4, 4, 2, 2], 0, 3 },
            { [1], 0, 1 },
        };
}
