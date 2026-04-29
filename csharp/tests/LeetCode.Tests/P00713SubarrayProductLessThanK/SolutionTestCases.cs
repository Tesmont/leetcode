using Xunit;

namespace LeetCode.Tests.P00713SubarrayProductLessThanK;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int> NumSubarrayProductLessThanKCases =>
        new()
        {
            { [10, 5, 2, 6], 100, 8 },
            { [1, 2, 3], 0, 0 },
        };
}
