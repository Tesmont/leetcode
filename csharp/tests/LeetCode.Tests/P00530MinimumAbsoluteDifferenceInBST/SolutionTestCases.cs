using Xunit;

namespace LeetCode.Tests.P00530MinimumAbsoluteDifferenceInBST;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int> GetMinimumDifferenceCases =>
        new()
        {
            { [4, 2, 6, 1, 3], 1 },
            { [1, 0, 48, null, null, 12, 49], 1 },
            { [2, 1], 1 },
        };
}
