using Xunit;

namespace LeetCode.Tests.P00167TwoSumIIInputArrayIsSorted;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int[]> TwoSumCases =>
        new()
        {
            { new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 } },
            { new[] { 2, 3, 4 }, 6, new[] { 1, 3 } },
            { new[] { -1, 0 }, -1, new[] { 1, 2 } },
            { new[] { 1, 2, 3, 4, 4, 9, 56, 90 }, 8, new[] { 4, 5 } },
        };
}
