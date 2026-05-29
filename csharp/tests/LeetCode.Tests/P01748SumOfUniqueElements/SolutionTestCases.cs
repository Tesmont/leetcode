using Xunit;

namespace LeetCode.Tests.P01748SumOfUniqueElements;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> SumOfUniqueCases =>
        new()
        {
            { [1, 2, 3, 2], 4 },
            { [1, 1, 1, 1, 1], 0 },
            { [1, 2, 3, 4, 5], 15 },
        };
}
