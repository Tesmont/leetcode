using Xunit;

namespace LeetCode.Tests.P00930BinarySubarraysWithSum;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int> NumSubarraysWithSumCases =>
        new()
        {
            { [1, 0, 1, 0, 1], 2, 4 },
            { [0, 0, 0, 0, 0], 0, 15 },
            { [1], 1, 1 },
            { [0], 1, 0 },
        };
}
