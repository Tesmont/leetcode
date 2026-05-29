using Xunit;

namespace LeetCode.Tests.P01426CountingElements;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> CountElementsCases =>
        new()
        {
            { [1, 2, 3], 2 },
            { [1, 1, 3, 3, 5, 5, 7, 7], 0 },
        };
}
