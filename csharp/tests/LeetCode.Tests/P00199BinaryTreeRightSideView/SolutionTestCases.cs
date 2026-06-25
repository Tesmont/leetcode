using Xunit;

namespace LeetCode.Tests.P00199BinaryTreeRightSideView;

public static class SolutionTestCases
{
    public static TheoryData<int?[], int[]> RightSideViewCases =>
        new()
        {
            { [1, 2, 3, null, 5, null, 4], [1, 3, 4] },
            { [1, 2, 3, 4, null, null, null, 5], [1, 3, 4, 5] },
            { [1, null, 3], [1, 3] },
            { [], [] },
        };
}
