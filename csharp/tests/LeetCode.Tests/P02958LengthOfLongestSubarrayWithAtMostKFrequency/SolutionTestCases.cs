using Xunit;

namespace LeetCode.Tests.P02958LengthOfLongestSubarrayWithAtMostKFrequency;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int> MaxSubarrayLengthCases =>
        new()
        {
            { [1, 2, 3, 1, 2, 3, 1, 2], 2, 6 },
            { [1, 2, 1, 2, 1, 2, 1, 2], 1, 2 },
            { [5, 5, 5, 5, 5, 5, 5], 4, 4 },
            { [1], 1, 1 },
        };
}
