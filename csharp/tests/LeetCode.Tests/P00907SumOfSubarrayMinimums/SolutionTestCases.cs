using Xunit;

namespace LeetCode.Tests.P00907SumOfSubarrayMinimums;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> SumSubarrayMinsCases =>
        new()
        {
            { [3, 1, 2, 4], 17 },
            { [11, 81, 94, 43, 3], 444 },
            { [1], 1 },
            { [1, 1, 1], 6 },
        };
}
