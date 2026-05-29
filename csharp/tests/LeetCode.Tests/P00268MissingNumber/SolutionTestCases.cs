using Xunit;

namespace LeetCode.Tests.P00268MissingNumber;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> MissingNumberCases =>
        new()
        {
            { [3, 0, 1], 2 },
            { [0, 1], 2 },
            { [9, 6, 4, 2, 3, 5, 7, 0, 1], 8 },
        };
}
