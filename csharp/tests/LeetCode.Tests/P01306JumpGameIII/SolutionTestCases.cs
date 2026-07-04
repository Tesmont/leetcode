using Xunit;

namespace LeetCode.Tests.P01306JumpGameIII;

public static class SolutionTestCases
{
    public static TheoryData<int[], int, bool> CanReachCases =>
        new()
        {
            { [4, 2, 3, 0, 3, 1, 2], 5, true },
            { [4, 2, 3, 0, 3, 1, 2], 0, true },
            { [3, 0, 2, 1, 2], 2, false },
        };
}
