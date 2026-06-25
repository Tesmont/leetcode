using Xunit;

namespace LeetCode.Tests.P01302DeepestLeavesSum;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int> DeepestLeavesSumCases =>
        new()
        {
            { [1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8], 15 },
            { [6, 7, 8, 2, 7, 1, 3, 9, null, 1, 4, null, null, null, 5], 19 },
            { [1], 1 },
            { [1, null, 2, null, 3], 3 },
        };
}
