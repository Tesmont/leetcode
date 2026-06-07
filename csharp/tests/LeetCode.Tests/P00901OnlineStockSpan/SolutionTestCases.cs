using Xunit;

namespace LeetCode.Tests.P00901OnlineStockSpan;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> OnlineStockSpanCases =>
        new()
        {
            { [100, 80, 60, 70, 60, 75, 85], [1, 1, 1, 2, 1, 4, 6] },
        };
}
