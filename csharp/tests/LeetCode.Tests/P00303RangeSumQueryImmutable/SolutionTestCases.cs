using Xunit;

namespace LeetCode.Tests.P00303RangeSumQueryImmutable;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[][], int[]> SumRangeCases =>
        new()
        {
            { [-2, 0, 3, -5, 2, -1], [[0, 2], [2, 5], [0, 5]], [1, -1, -3] },
        };
}
