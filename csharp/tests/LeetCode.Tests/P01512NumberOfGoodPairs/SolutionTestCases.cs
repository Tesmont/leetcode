using Xunit;

namespace LeetCode.Tests.P01512NumberOfGoodPairs;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> NumIdenticalPairsCases =>
        new()
        {
            { [1, 2, 3, 1, 1, 3], 4 },
            { [1, 1, 1, 1], 6 },
            { [1, 2, 3], 0 },
            { [5], 0 },
        };
}
