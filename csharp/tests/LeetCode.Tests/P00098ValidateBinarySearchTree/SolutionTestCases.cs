using Xunit;

namespace LeetCode.Tests.P00098ValidateBinarySearchTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], bool> IsValidBSTCases =>
        new()
        {
            { [2, 1, 3], true },
            { [5, 1, 4, null, null, 3, 6], false },
            { [1], true },
            { [2, 2, 2], false },
            { [5, 4, 6, null, null, 3, 7], false },
            { [0, int.MinValue, int.MaxValue], true },
        };
}
