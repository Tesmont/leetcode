using Xunit;

namespace LeetCode.Tests.P00525ContiguousArray;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> FindMaxLengthCases =>
        new()
        {
            { [0, 1], 2 },
            { [0, 1, 0], 2 },
            { [0], 0 },
            { [0, 1, 1, 1, 1, 1, 0, 0, 0], 6 },
        };
}
