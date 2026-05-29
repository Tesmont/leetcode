using Xunit;

namespace LeetCode.Tests.P01991FindTheMiddleIndexInArray;

public static class SolutionTestCases
{
    public static TheoryData<int[], int> FindMiddleIndexCases =>
        new()
        {
            { [2, 3, -1, 8, 4], 3 },
            { [1, -1, 4], 2 },
            { [2, 5], -1 },
        };
}
