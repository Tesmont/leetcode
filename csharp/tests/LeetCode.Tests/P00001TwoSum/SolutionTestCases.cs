using Xunit;

namespace LeetCode.Tests.P00001TwoSum;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int[]> TwoSumCases =>
        new()
        {
            { [2, 7, 11, 15], 9, [0, 1] },
            { [3, 2, 4], 6, [1, 2] },
            { [3, 3], 6, [0, 1] },
        };
}
