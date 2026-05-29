using Xunit;

namespace LeetCode.Tests.P01394FindLuckyIntegerInAnArray;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> FindLuckyCases =>
        new()
        {
            { [2, 2, 3, 4], 2 },
            { [1, 2, 2, 3, 3, 3], 3 },
            { [2, 2, 2, 3, 3], -1 },
            { [5], -1 },
            { [1], 1 },
            { [4, 4, 4, 4, 3, 3, 3], 4 },
        };
}
