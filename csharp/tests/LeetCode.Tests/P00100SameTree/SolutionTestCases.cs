using Xunit;

namespace LeetCode.Tests.P00100SameTree;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int?[], bool> IsSameTreeCases =>
        new()
        {
            { [1, 2, 3], [1, 2, 3], true },
            { [1, 2], [1, null, 2], false },
            { [1, 2, 1], [1, 1, 2], false },
            { [], [], true },
        };
}
