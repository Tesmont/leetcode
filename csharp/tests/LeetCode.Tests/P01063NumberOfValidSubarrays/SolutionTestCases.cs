using Xunit;

namespace LeetCode.Tests.P01063NumberOfValidSubarrays;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> ValidSubarraysCases =>
        new()
        {
            { [1, 4, 2, 5, 3], 11 },
            { [3, 2, 1], 3 },
            { [2, 2, 2], 6 },
            { [1], 1 },
            { [1, 2, 3, 4], 10 },
        };
}
