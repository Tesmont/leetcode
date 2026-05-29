using Xunit;

namespace LeetCode.Tests.P01248CountNumberOfNiceSubarrays;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int> NumberOfSubarraysCases =>
        new()
        {
            { [1, 1, 2, 1, 1], 3, 2 },
            { [2, 4, 6], 1, 0 },
            { [2, 2, 2, 1, 2, 2, 1, 2, 2, 2], 2, 16 },
        };
}
