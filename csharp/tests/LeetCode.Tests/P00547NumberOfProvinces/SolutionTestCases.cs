using Xunit;

namespace LeetCode.Tests.P00547NumberOfProvinces;

public static class SolutionTestCases
{
    public static TheoryData<int[][], int> FindCircleNumCases =>
        new()
        {
            { [[1, 1, 0], [1, 1, 0], [0, 0, 1]], 2 },
            { [[1, 0, 0], [0, 1, 0], [0, 0, 1]], 3 },
        };
}
