using Xunit;

namespace LeetCode.Tests.P00270ClosestBinarySearchTreeValue;

public static class SolutionTestCases
{
    public static TheoryData<int?[], double, int> ClosestValueCases =>
        new()
        {
            { [4, 2, 5, 1, 3], 3.714286, 4 },
            { [1], 4.428571, 1 },
        };
}
