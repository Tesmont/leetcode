using Xunit;

namespace LeetCode.Tests.P01133LargestUniqueNumber;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> LargestUniqueNumberCases =>
        new()
        {
            { [5, 7, 3, 9, 4, 9, 8, 3, 1], 8 },
            { [9, 9, 8, 8], -1 },
            { [1], 1 },
        };
}
