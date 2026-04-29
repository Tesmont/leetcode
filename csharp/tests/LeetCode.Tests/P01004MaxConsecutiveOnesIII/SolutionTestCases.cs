using Xunit;

namespace LeetCode.Tests.P01004MaxConsecutiveOnesIII;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, int> LongestOnesCases =>
        new()
        {
            { [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2, 6 },
            { [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 3, 10 }
        };
}
