using Xunit;

namespace LeetCode.Tests.P01046LastStoneWeight;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> LastStoneWeightCases =>
        new()
        {
            { [2, 7, 4, 1, 8, 1], 1 },
            { [1], 1 },
            { [1, 1], 0 },
            { [10, 4, 2, 10], 2 },
        };
}
